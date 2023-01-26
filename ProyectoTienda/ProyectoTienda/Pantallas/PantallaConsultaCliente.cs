using ProyectoTienda.Clientes;
using ProyectoTienda.Utils;
using System;
using System.Drawing;
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

            IntermediarioEventos.compraCancelada += AbilitarCompra;
        }

        // INICIALIZACION

        private void PantallaConsultaCliente_Load(object sender, EventArgs e)
        {
            ChecarCompraActiva();
            DisplayCliente();
            DisplayHijos();
            AbilitarInputDeTexto(false);
        }

        // UTILIDADES

        private void ChecarCompraActiva()
        {
            if(IntermediarioEventos.CompraActiva())
            {
                DeshabilitarCompra();
            }
            else
            {
                AbilitarCompra();
            }
        }

        private void DeshabilitarCompra()
        {
            BotonCompra.Enabled = false;
            BotonCompra.Text = "Compra Activa";
            BotonCompra.BackColor = Color.Gray;
            BotonEliminarCliente.Visible = false;
            BotonEditar.Enabled = false;
            BotonEditar.BackColor = Color.Gray;
        }

        private void AbilitarCompra()
        {
            BotonCompra.Enabled = true;
            BotonCompra.Text = "Comenzar Compra";
            BotonEliminarCliente.Visible = true;
            BotonEditar.Visible = true;
        }

        private void DisplayCliente()
        {
            ConsultaUsuarioTexto.Text = cliente.CLIENTE_USUARIO;
            ConsultaNombreTexto.Text = cliente.CLIENTE_NOMBRE;
            ConsultaEmailTexto.Text = cliente.CLIENTE_EMAIL;
            ConsultaTelefonoTexto.Text = cliente.CLIENTE_TELEFONO;
            ConsultaDeudaTexto.Text = cliente.CLIENTE_DEUDA.ToString();
            ConsultaFechaTexto.Text = cliente.CLIENTE_CREACION;
        }

        private void DisplayHijos()
        {
            // TODO
        }

        private void CambiarInformacion()
        {
            cliente.CLIENTE_NOMBRE = ConsultaNombreTexto.Text;
            cliente.CLIENTE_EMAIL = ConsultaEmailTexto.Text;
            cliente.CLIENTE_TELEFONO = ConsultaTelefonoTexto.Text;
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

        // EVENTOS DE INPUT

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowDragging.ApplyWindowDragging(this);
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            AbilitarInputDeTexto(true);
            BotonEditar.Visible = false;
            BotonCambioCliente.Visible = true;
        }

        private void BotonCambioCliente_Click(object sender, EventArgs e)
        {
            string nombre = ConsultaNombreTexto.Text;
            string email = ConsultaEmailTexto.Text;
            string telefono = ConsultaTelefonoTexto.Text;

            if (ValidadorCliente.ValidarModificacion(nombre, email, telefono))
            {
                bool opcion = MessageBoxes.ShowYesNoOptionBox($"Aplicar cambios a {cliente.CLIENTE_USUARIO}?", "Confirmar");

                if (opcion)
                {
                    cliente.CLIENTE_NOMBRE = nombre;
                    cliente.CLIENTE_EMAIL = email;
                    cliente.CLIENTE_TELEFONO = telefono;
                    cliente.AplicarModificaciones();
                    informacionActualizada?.Invoke();
                    MessageBoxes.ShowSuccessBox("Cliente modificado con exito");
                }

                DeshabilitarInputDeTablas();
            } 
        }

        private void BotonEliminarCliente_Click(object sender, EventArgs e)
        {
            bool opcion = MessageBoxes.ShowYesNoOptionBox($"Eliminar a {cliente.CLIENTE_USUARIO}?", "Confirmar");

            if(opcion)
            {
                if (!cliente.RemoverEsteCliente())
                {
                    MessageBoxes.ShowErrorBox("Error al eliminar cliente");
                    return;
                }

                informacionActualizada?.Invoke();
                MessageBoxes.ShowSuccessBox("Cliente eliminado con exito");
                Close();
            }       
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClickFueraDeArea(object sender, EventArgs e)
        {
            if (BotonCambioCliente.Visible || BotonEliminarCliente.Visible) return;

            Close();           
        }

        private void BotonCompra_Click(object sender, EventArgs e)
        {
            //compraIniciada?.Invoke(cliente);
            //compraActiva = true;

            IntermediarioEventos.IniciarCompra(cliente);
          
            Close();
        }
    }
}
