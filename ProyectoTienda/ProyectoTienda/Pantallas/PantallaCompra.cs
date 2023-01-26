using System;
using ProyectoTienda.Clientes;
using System.Windows.Forms;
using ProyectoTienda.Compras;
using ProyectoTienda.Inventario;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaCompra : Form
    {
        private Cliente clienteActual = null;
        private Compra compraActual = null;

        public PantallaCompra() 
        {
            InitializeComponent();

            IntermediarioEventos.compraIniciada += IniciarCompraPara;
            IntermediarioEventos.productoAgregado += AgregarProductoACompra;
        }

        private void IniciarCompraPara(Cliente cliente)
        {
            clienteActual = cliente;
            compraActual = new Compra();

            ToggleCompra(true);
        }

        // UTILIDADES

        private void AgregarProductoACompra(Producto producto)
        {
            compraActual.Agregar(producto);
            TotalTexto.Text = compraActual.ObtenerTotal().ToString();
            ToggleCompra(true);
        }

        private void ToggleCompra(bool estado)
        {
            if (clienteActual == null) return;

            DisplayCarrito();
            ToggleGUI(estado);

            TogglePagoEfectivo(false);
            TogglePagoTarjeta(false);
        }

        private void TogglePagoEfectivo(bool estado)
        {
            LabelCantidadAPagar.Visible = estado;
            TextoCantidadAPagar.Visible = estado;
        }

        private void TogglePagoTarjeta(bool estado)
        {
            LabelNombreTarjeta.Visible = estado;
            LabelNumeroTarjeta.Visible = estado;
            LabelCVV.Visible = estado;
            TextoNombreTarjeta.Visible = estado;
            TextoNumeroTarjeta.Visible = estado;
            TextoCVV.Visible = estado;
        }

        private void DisplayCarrito()
        {
            if (TablaProductos == null) return;

            BindingSource fuente = new BindingSource();
            fuente.DataSource = compraActual.ObtenerListaDeProductos();
            TablaProductos.DataSource = fuente;

            foreach (DataGridViewColumn column in TablaProductos.Columns)
            {
                if (column.Name == "PRODUCTO_CREACION")
                {
                    column.Visible = false;
                }
            }
        }

        private void ToggleGUI(bool estado)
        {
            NombreCliente.Text = $"Compra de {clienteActual.CLIENTE_NOMBRE}";

            IndicacionLabel.Visible = !estado;
            NombreCliente.Visible = estado;
            BotonCancelarCompra.Visible = estado;
            BotonPagar.Visible = estado;
            TablaProductos.Visible = estado;
            ProductosLabel.Visible = estado;
            labelTicket.Visible = estado;
            LabelTotal.Visible = estado;
            TotalTexto.Visible = estado;
            CheckboxPagoEfectivo.Visible = estado;
            CheckboxPagoTarjeta.Visible = estado;
            LabelCantidadAPagar.Visible = estado;
            TextoCantidadAPagar.Visible = estado;
        }

        private void RefrescarDatos()
        {
            TotalTexto.Clear();
            TextoCantidadAPagar.Clear();
            TextoNombreTarjeta.Clear();
            TextoNumeroTarjeta.Clear();
            TextoCVV.Clear();

            CheckboxPagoEfectivo.Checked = false;
            CheckboxPagoTarjeta.Checked = false;
        }

        private void Cancelar()
        {
            IntermediarioEventos.CancelarCompra();

            ToggleCompra(false);
            RefrescarDatos();

            TablaProductos.DataSource = null;
            compraActual = null;
        }

        private void AplicarCambiosAProductos()
        {
            if (compraActual.ObtenerListaDeProductos() == null) return;

            foreach(Producto producto in compraActual.ObtenerListaDeProductos())
            {
                producto.AplicarModificacion();
            }
        }

        private void AplicarCambiosACliente()
        {
            if (clienteActual == null) return;

            clienteActual.AplicarModificaciones();
        }

        private void PagarConTarjeta()
        {
            string numeroTarjeta = TextoNumeroTarjeta.Text;
            string nombreTarjeta = TextoNombreTarjeta.Text;
            string CVV = TextoCVV.Text;

            if (ValidadorCompras.ValidarPagoConTarjeta(nombreTarjeta, numeroTarjeta, CVV))
            {
                bool opcion = Utils.MessageBoxes.ShowYesNoOptionBox($"Confirmar la compra?", "Confirmar");

                if (opcion)
                {
                    AplicarCambiosAProductos();

                    Utils.MessageBoxes.ShowSuccessBox("Compra exitosa");

                    Cancelar();
                }
            }
        }

        private void AplicarDeudaACliente(float pago)
        {
            float deuda = compraActual.ObtenerTotal() - pago;
            bool opcionDeuda = Utils.MessageBoxes.ShowYesNoOptionBox($"El cliente quedara a deber {deuda}", "Confirmar");

            if (opcionDeuda)
            {
                clienteActual.CLIENTE_DEUDA += deuda;
                AplicarCambiosACliente();
            }
        }

        private void ObtenerCambio(float pago)
        {
            float cambio = pago - compraActual.ObtenerTotal();
            Utils.MessageBoxes.ShowSuccessBox($"Cambio para el cliente: {cambio}");
        }

        private void PagarConEfectivo()
        {
            string pagoEfectivoTexto = TextoCantidadAPagar.Text;
            int pagoEfectivoNumero = 0;

            if (ValidadorCompras.ValidarPagoEfectivo(pagoEfectivoTexto, out pagoEfectivoNumero))
            {
                if(pagoEfectivoNumero < compraActual.ObtenerTotal())
                {
                    AplicarDeudaACliente(pagoEfectivoNumero);
                }

                if(pagoEfectivoNumero > compraActual.ObtenerTotal())
                {
                    ObtenerCambio(pagoEfectivoNumero);
                }

                AplicarCambiosAProductos();

                Utils.MessageBoxes.ShowSuccessBox("Compra exitosa");

                Cancelar();         
            }
        }

        private void ChecarTipoDePago()
        {
            if (!CheckboxPagoEfectivo.Checked && !CheckboxPagoTarjeta.Checked)
            {
                Utils.MessageBoxes.ShowErrorBox("Seleccione un metodo de pago");
                return;
            }

            if (compraActual.ObtenerListaDeProductos() == null)
            {
                Utils.MessageBoxes.ShowErrorBox("El carrito esta vacio");
                return;
            }

            if (CheckboxPagoEfectivo.Checked)
            {
                PagarConEfectivo();
            }

            else if (CheckboxPagoTarjeta.Checked)
            {
                PagarConTarjeta();
            }
        }

        // EVENTOS DE INPUT

        private void BotonCancelarCompra_Click(object sender, EventArgs e)
        {
            bool opcion = Utils.MessageBoxes.ShowYesNoOptionBox($"Cancelar compra actual?", "Confirmar");

            if(opcion)
            {
                Cancelar();
            }
        }

        private void CheckboxPagoTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxPagoEfectivo.Checked = !CheckboxPagoTarjeta.Checked;

            if(CheckboxPagoTarjeta.Checked)
            {
                TogglePagoTarjeta(true);
                TogglePagoEfectivo(false);
            }
        }

        private void CheckboxPagoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxPagoTarjeta.Checked = !CheckboxPagoEfectivo.Checked;

            if(CheckboxPagoEfectivo.Checked)
            {
                TogglePagoTarjeta(false);
                TogglePagoEfectivo(true);
            }
        }

        private void BotonPagar_Click(object sender, EventArgs e)
        {
            ChecarTipoDePago();
        }
    }
}
