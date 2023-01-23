using ProyectoTienda.Clientes;
using ProyectoTienda.Utils;
using System;
using System.Windows.Forms;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaConsultaCliente : Form
    {
        private Cliente cliente;

        public static event Action informacionActualizada;

        public PantallaConsultaCliente(Cliente cliente)
        {
            this.cliente = cliente;

            InitializeComponent();
            DisplayCliente();
            DisplayHijos();
            AbilitarInputDeTexto(false);
        }

        // FUNCTIONALITY

        private void DisplayCliente()
        {
            ConsultaUsuarioTexto.Text = cliente.ObtenerUsuario();
            ConsultaNombreTexto.Text = cliente.ObtenerNombre();
            ConsultaEmailTexto.Text = cliente.ObtenerEmail();
            ConsultaTelefonoTexto.Text = cliente.ObtenerTelefono();
            ConsultaDeudaTexto.Text = cliente.ObtenerDeuda().ToString();
            ConsultaFechaTexto.Text = cliente.ObtenerFechaCreacion();
        }

        private void DisplayHijos()
        {
            foreach(Hijo hijo in cliente.ObtenerHijos())
            {
                ConsultaHijosTabla.Rows.Add(hijo.nombre, hijo.departamento.ToString());
            }
        }

        private void CambiarInformacion()
        {
            cliente.CambiarNombre(ConsultaNombreTexto.Text);
            cliente.CambiarEmail(ConsultaEmailTexto.Text);
            cliente.CambiarTelefono(ConsultaTelefonoTexto.Text);
        }

        private void AbilitarInputDeTexto(bool estado)
        {
            ConsultaNombreTexto.Enabled = estado;
            ConsultaEmailTexto.Enabled = estado;
            ConsultaTelefonoTexto.Enabled = estado;
        }

        private void DeshabilitarInputDeTablas()
        {
            AbilitarInputDeTexto(false);
            BotonEditar.Visible = true;
            BotonCambioCliente.Visible = false;
        }

        // INPUT EVENTS

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            AbilitarInputDeTexto(true);
            BotonEditar.Visible = false;
            BotonCambioCliente.Visible = true;
        }

        private void BotonCambioCliente_Click(object sender, EventArgs e)
        {
            bool opcion = MessageBoxes.ShowYesNoOptionBox($"Aplicar cambios a {cliente.ObtenerUsuario()}?", "Confirmar");

            if (opcion)
            {
                CambiarInformacion();
                informacionActualizada?.Invoke();              
            }

            DeshabilitarInputDeTablas();
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowDragging.ApplyWindowDragging(this);
        }

        private void ClickFueraDeArea(object sender, EventArgs e)
        {
            if (BotonCambioCliente.Visible) return;
            
            Hide();           
        }
    }
}
