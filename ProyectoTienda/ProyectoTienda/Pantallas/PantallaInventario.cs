using ProyectoTienda.Inventario;
using ProyectoTienda.Utils;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaInventario : Form
    {
        private const int indexColumnaNombres = 0;

        public PantallaInventario()
        {
            PantallaConsultaProducto.productoModificado += DisplayProductos;

            InitializeComponent();         
        }

        // INICIALIZACION

        private void PantallaInventario_Load(object sender, EventArgs e)
        {
            DisplayProductos();
            LlenarDropDownDeCategorias();
        }

        // UTILIDADES

        private void DisplayProductos()
        {
            DataTable tablaInventario = Producto.ObtenerTablaFiltradaDeProductos();
            InventarioTabla.DataSource = tablaInventario;
        }

        private void LlenarDropDownDeCategorias()
        {
            CategoriaDropDown.DataSource = Enum.GetValues(typeof(ProductoCategoria));
            CategoriaDropDown.DropDownStyle = ComboBoxStyle.DropDownList;

            CategoriaFiltroDropDown.DataSource = Enum.GetValues(typeof(ProductoCategoria));
            CategoriaFiltroDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void RefrescarTexto()
        {
            NombreTexto.Clear();
            CategoriaDropDown.SelectedIndex = 0;      
            PrecioTexto.Clear();
            StockTexto.Clear();
        }

        private bool FiltrarPorCategoria(ProductoCategoria categoria)
        {
            var categoriaFiltrada = Producto.ObtenerTablaFiltradaDeProductos().AsEnumerable()
                                    .Where(row => row.Field<string>(Producto.ObtenerColumnaCategoria()) == categoria.ToString());

            if(categoriaFiltrada.Count() == 0)
            {
                return false;
            }

            InventarioTabla.DataSource = categoriaFiltrada.AsDataView();
            return true;
        }

        // EVENTOS DE INPUT

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            string nombre = NombreTexto.Text;
            string categoria = CategoriaDropDown.SelectedItem.ToString();
            string stock = StockTexto.Text;
            string precio = PrecioTexto.Text;

            ProductoCategoria categoriaEnum = default;
            int stockNumero = 0;
            float precioNumero = 0;

            if(ValidadorProducto.ValidarInsercion(nombre, categoria, out categoriaEnum, stock, out stockNumero, precio, out precioNumero))
            {
                Producto nuevoProducto = new Producto(nombre, categoriaEnum, stockNumero, precioNumero);

                if(nuevoProducto != null && nuevoProducto.AplicarInsercion())
                {
                    MessageBoxes.ShowSuccessBox("Producto creado con exito");

                    RefrescarTexto();
                    DisplayProductos();
                }
                else
                {
                    MessageBoxes.ShowErrorBox("Error al crear producto");
                }
            }
        }

        private void BotonFiltrarCategoria_Click(object sender, EventArgs e)
        {
            string categoria = CategoriaFiltroDropDown.SelectedItem.ToString();
            ProductoCategoria categoriaEnum = default;

            if(!ValidadorProducto.EsCategoria(categoria, out categoriaEnum))
            {
                MessageBoxes.ShowErrorBox("Categoria invalida");
                return;
            }

            if(!FiltrarPorCategoria(categoriaEnum))
            {
                MessageBoxes.ShowErrorBox("No hay productos con esta categoria");
                return;
            }
        }

        private void InventarioTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celdaSeleccionada = InventarioTabla.CurrentCell;

            if (celdaSeleccionada != null)
            {
                if (celdaSeleccionada.RowIndex < 0) return;

                string datoCelda = celdaSeleccionada.Value.ToString();

                if (celdaSeleccionada.ColumnIndex != indexColumnaNombres) return;

                Producto productoSeleccionado = Producto.ObtenerNuevoConNombre(datoCelda);

                if (productoSeleccionado == null) return;

                PantallaConsultaProducto pantallaConsulta = new PantallaConsultaProducto(productoSeleccionado);

                pantallaConsulta.Show();
            }
        }
    }
}
