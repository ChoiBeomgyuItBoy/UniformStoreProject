using ProyectoTienda.Inventario;
using ProyectoTienda.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaConsultaProducto : Form
    {
        private Producto producto;

        public static event Action productoModificado;

        private event Action productoAgotado;

        public PantallaConsultaProducto(Producto producto)
        {
            this.producto = producto;

            productoAgotado += ChecarProductoAgotado;

            InitializeComponent();
        }

        // INICIALIZACION

        private void PantallaConsultaProducto_Load(object sender, EventArgs e)
        {
            ChecarProductoAgotado();
            ChecarCompraActual();
            LlenarDropDownDeCategorias();
            DisplayProducto();
        }

        // UTILIDADES

        private void ChecarProductoAgotado()
        {
            if (producto == null) return;

            if(producto.PRODUCTO_STOCK <= 0)
            {
                BotonCompra.Enabled = false;
                BotonCompra.BackColor = Color.Gray;
                BotonCompra.Text = "Producto Agotado";
            }
        }

        private void ChecarCompraActual()
        {
            if(IntermediarioEventos.CompraActiva())
            {
                HabilitarCompra();
            }
            else
            {
                DeshabilitarCompra();
            }
        }

        private void HabilitarCompra()
        {
            BotonCompra.Visible = true;
            BotonEliminarProducto.Visible = false;
            BotonEditar.Enabled = false;
            BotonEditar.BackColor = Color.Gray;
        }

        private void DeshabilitarCompra()
        {
            BotonCompra.Visible = false;
            BotonEliminarProducto.Visible = true;
            BotonEditar.Enabled = true;
        }

        private void DisplayProducto()
        {
            NombreTexto.Text = producto.PRODUCTO_NOMBRE;
            CategoriaDropDown.SelectedItem = producto.PRODUCTO_CATEGORIA;
            StockTexto.Text = producto.PRODUCTO_STOCK.ToString();
            PrecioTexto.Text = producto.PRODUCTO_PRECIO.ToString();
            CreacionTexto.Text = producto.PRODUCTO_CREACION;
        }

        private void LlenarDropDownDeCategorias()
        {
            CategoriaDropDown.DataSource = Enum.GetValues(typeof(ProductoCategoria));
            CategoriaDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AbilitarInputDeTexto(bool estado)
        {
            CategoriaDropDown.Enabled = estado;
            PrecioTexto.Enabled = estado;
            StockTexto.Enabled = estado;
        }

        // EVENTOS DE INPUT

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            AbilitarInputDeTexto(true);
            BotonEditar.Visible = false;
            BotonActualizar.Visible = true;
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            string categoria = CategoriaDropDown.SelectedItem.ToString();
            string stock = StockTexto.Text;
            string precio = PrecioTexto.Text;

            ProductoCategoria categoriaEnum = default;
            int stockNumero = 0;
            float precioNumero = 0;

            if (ValidadorProducto.ValidarModificacion(categoria, out categoriaEnum, stock, out stockNumero, precio, out precioNumero))
            {
                bool opcion = MessageBoxes.ShowYesNoOptionBox($"Aplicar cambios a {producto.PRODUCTO_NOMBRE}?", "Confirmar");

                if (opcion)
                {
                    producto.PRODUCTO_CATEGORIA = categoriaEnum;
                    producto.PRODUCTO_STOCK = stockNumero;
                    producto.PRODUCTO_PRECIO = precioNumero;
                    producto.AplicarModificacion();
                    productoModificado?.Invoke();
                    MessageBoxes.ShowSuccessBox("Producto modificado con exito");

                    AbilitarInputDeTexto(false);
                    BotonEditar.Visible = true;
                    BotonActualizar.Visible = false;
                }
            }
        }

        private void BotonEliminarProducto_Click(object sender, EventArgs e)
        {
            bool opcion = MessageBoxes.ShowYesNoOptionBox($"Eliminar {producto.PRODUCTO_NOMBRE}?", "Confirmar");

            if (opcion)
            {
                if (!producto.RemoverEsteProducto())
                {
                    MessageBoxes.ShowErrorBox("Error al eliminar producto");
                    return;
                }

                productoModificado?.Invoke(); 
                MessageBoxes.ShowSuccessBox("Producto eliminado con exito");
                Close();
            }
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowDragging.ApplyWindowDragging(this);
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClickFueraDeArea(object sender, EventArgs e)
        {
            if (BotonActualizar.Visible || BotonEliminarProducto.Visible || BotonCompra.Visible) return;

            Close();
        }

        private void BotonCompra_Click(object sender, EventArgs e)
        {
            bool opcion = MessageBoxes.ShowYesNoOptionBox($"Agregar {producto.PRODUCTO_NOMBRE} a compra actual?", "Confirmar");

            if (opcion)
            {
                producto.PRODUCTO_STOCK--;

                productoAgotado?.Invoke();

                StockTexto.Text = producto.PRODUCTO_STOCK.ToString();

                IntermediarioEventos.AgregarProducto(producto);
                MessageBoxes.ShowSuccessBox("Producto agregado con exito");
            }
        }
    }
}
