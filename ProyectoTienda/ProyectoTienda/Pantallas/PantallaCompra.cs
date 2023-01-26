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
            MostrarCompraUI();
        }

        // UTILIDADES

        private void AgregarProductoACompra(Producto producto)
        {
            compraActual.Agregar(producto);
            TotalTexto.Text = compraActual.ObtenerTotal().ToString();
            DisplayCarrito();
        }

        private void MostrarCompraUI()
        {
            if (clienteActual == null) return;

            DisplayCarrito();
            ToggleInformacionCompra(true);
            TogglePagoEfectivo(false);
            TogglePagoTarjeta(false);
        }

        private void EsconderCompraUI()
        {
            if (clienteActual == null) return;

            DisplayCarrito();
            ToggleInformacionCompra(false);
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

        private void ToggleInformacionCompra(bool estado)
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

            RefrescarDatos();
            EsconderCompraUI();

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

        private bool PagarConEfectivo()
        {
            string pagoEfectivoTexto = TextoCantidadAPagar.Text;
            int pagoEfectivoNumero = 0;

            if (ValidadorCompras.ValidarPagoEfectivo(pagoEfectivoTexto, out pagoEfectivoNumero))
            {
                if (pagoEfectivoNumero < compraActual.ObtenerTotal())
                {
                    return AplicarDeudaACliente(pagoEfectivoNumero);
                }

                if (pagoEfectivoNumero > compraActual.ObtenerTotal())
                {
                    ObtenerCambio(pagoEfectivoNumero);
                    return true;
                }
            }

            return false;
        }

        private bool PagarConTarjeta()
        {
            string numeroTarjeta = TextoNumeroTarjeta.Text;
            string nombreTarjeta = TextoNombreTarjeta.Text;
            string CVV = TextoCVV.Text;

            if (ValidadorCompras.ValidarPagoConTarjeta(nombreTarjeta, numeroTarjeta, CVV))
            {
                return Utils.MessageBoxes.ShowYesNoOptionBox($"Confirmar la compra?", "Confirmar");
            }

            return false;
        }

        private bool AplicarDeudaACliente(float pago)
        {
            float deuda = compraActual.ObtenerTotal() - pago;
            bool opcionDeuda = Utils.MessageBoxes.ShowYesNoOptionBox($"El cliente quedara a deber {deuda}", "Confirmar");

            if (opcionDeuda)
            {
                clienteActual.CLIENTE_DEUDA += deuda;
                AplicarCambiosACliente();
                return true;
            }

            return false;
        }

        private void ObtenerCambio(float pago)
        {
            float cambio = pago - compraActual.ObtenerTotal();
            Utils.MessageBoxes.ShowSuccessBox($"Cambio para el cliente: {cambio}");
        }


        private bool ChecarTipoDePago()
        {
            if (!CheckboxPagoEfectivo.Checked && !CheckboxPagoTarjeta.Checked)
            {
                Utils.MessageBoxes.ShowErrorBox("Seleccione un metodo de pago");
                return false;
            }

            if (compraActual.ObtenerListaDeProductos() == null)
            {
                Utils.MessageBoxes.ShowErrorBox("El carrito esta vacio");
                return false;
            }

            if (CheckboxPagoEfectivo.Checked)
            {
                return PagarConEfectivo();
            }
            else if (CheckboxPagoTarjeta.Checked)
            {
                return PagarConTarjeta();
            }

            return false;
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
            if(ChecarTipoDePago())
            {
                int cantidad = compraActual.ObtenerListaDeProductos().Count;
                float total = compraActual.ObtenerTotal();

                IntermediarioEventos.FinalizarCompra(clienteActual, cantidad, total);

                AplicarCambiosAProductos();
                Utils.MessageBoxes.ShowSuccessBox("Compra exitosa");

                Cancelar();
            }
        }
    }
}
