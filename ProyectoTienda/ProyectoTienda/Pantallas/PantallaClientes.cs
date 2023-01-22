using ProyectoTienda.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaClientes : Form
    {
        private const int indexColumnaUsuarios = 1;

        public PantallaClientes()
        {
            InitializeComponent();
        }

        private void PantallaClientes_Load(object sender, EventArgs e)
        {
            DisplayClientes();
        }

        private void BotonNuevoCliente_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioTexto.Text;
            string nombre = NombreTexto.Text;
            string email = EmailTexto.Text;
            string telefono = TelefonoTexto.Text;

            if((usuario == "") || (nombre == "") || (email == "") || (telefono == ""))
            {
                return;
            }
            else if(Cliente.UsuarioExistente(usuario))
            {
                MessageBox.Show("Usuario ya existente");
                return;
            }

            CrearNuevoCliente(usuario, nombre, telefono, email);
        }

        private void ClienteTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celdaSeleccionada = ClienteTabla.CurrentCell;

            if(celdaSeleccionada != null)
            {
                if (celdaSeleccionada.RowIndex < 0) return;

                string datoCelda = celdaSeleccionada.Value.ToString();

                if (celdaSeleccionada.ColumnIndex != indexColumnaUsuarios) return;

                if (!Cliente.UsuarioExistente(datoCelda)) return;
                
                Cliente clienteSeleccionado = Cliente.ObtenerConUsuario(datoCelda);

                MessageBox.Show
                (
                    $"Datos de {datoCelda}\n" +
                    $"Nombre: {clienteSeleccionado.ObtenerNombre()}\n" +
                    $"Email: {clienteSeleccionado.ObtenerEmail()}\n" +
                    $"Telefono: {clienteSeleccionado.ObtenerTelefono()}"
                );
            }        
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            string usuarioConsulta = ConsultaTexto.Text;

            if(usuarioConsulta == "")
            {
                return;
            }
            else if(!Cliente.UsuarioExistente(usuarioConsulta))
            {
                MessageBox.Show("Usuario no existente");
                return;
            }

            DisplayCliente(usuarioConsulta);
        }

        private void CrearNuevoCliente(string usuario, string nombre, string telefono, string email)
        {
            Cliente nuevoCliente = new Cliente(usuario, nombre, telefono, email);

            UsuarioTexto.Clear();
            NombreTexto.Clear();
            TelefonoTexto.Clear();
            EmailTexto.Clear();

            ClienteTabla.Rows.Clear();
            DisplayClientes();

            MessageBox.Show("Nuevo cliente creado con exito");
        }

        private void DisplayClientes()
        {
            foreach (Cliente cliente in Cliente.ObtenerClientes())
            {
                if (cliente == null) continue;

                ClienteTabla.Rows.Add
                (
                    cliente.ObtenerNombre(),
                    cliente.ObtenerUsuario(),
                    cliente.ObtenerEmail(),
                    cliente.ObtenerTelefono()
                );
            }
        }

        private void DisplayCliente(string usuarioConsulta)
        {
            Cliente cliente = Cliente.ObtenerConUsuario(usuarioConsulta);

            if(cliente != null)
            {
                ClienteTabla.Rows.Clear();
                ClienteTabla.Rows.Add
                (
                    cliente.ObtenerNombre(),
                    cliente.ObtenerUsuario(),
                    cliente.ObtenerEmail(),
                    cliente.ObtenerTelefono()
                );
            }
        }
    }
}
