using ProyectoTienda.Clientes;
using ProyectoTienda.Reportes;
using System;
using System.Windows.Forms;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaVentas : Form
    {
        private const int indexColumnaID = 0;

        public PantallaVentas()
        {
            IntermediarioEventos.compraFinalizada += InsertarCompraATabla;

            InitializeComponent();
        }

        // INICIALIZACION

        private void PantallaVentas_Load(object sender, EventArgs e)
        {
            DisplayTablaDeVentas();
        }

        // UTILIDADES

        private void InsertarCompraATabla(Cliente cliente, int cantidad, float total)
        {
            Venta nuevaVenta = new Venta(cliente.CLIENTE_USUARIO, cantidad, total);

            if(nuevaVenta != null)
            {
                nuevaVenta.AplicarInsercion();
                DisplayTablaDeVentas();
            }
        }
        
        private void DisplayTablaDeVentas()
        {
            VentasTabla.DataSource = Venta.ObtenerTablaDeVentas();
        }

        // EVENTOS DE INPUT

        private void VentasTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celdaSeleccionada = VentasTabla.CurrentCell;

            if (celdaSeleccionada != null)
            {
                if (celdaSeleccionada.RowIndex < 0) return;

                string datoCelda = celdaSeleccionada.Value.ToString();

                if (celdaSeleccionada.ColumnIndex != indexColumnaID) return;

                Venta ventaSeleccionada = Venta.ObtenerConID(datoCelda);

                if (ventaSeleccionada == null) return;

                if(Utils.MessageBoxes.ShowYesNoOptionBox("Eliminar este reporte de venta?", "Eliminar reporte"))
                {
                    ventaSeleccionada.RemoverEstaVenta();
                    Utils.MessageBoxes.ShowSuccessBox("Reporte de venta eliminado con exito");
                    DisplayTablaDeVentas();
                }
            }
        }
    }
}
