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
            CrearDepartamentoDropDown();
        }

        private void BotonNuevoCliente_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioTexto.Text;
            string nombre = NombreTexto.Text;
            string email = EmailTexto.Text;
            string telefono = TelefonoTexto.Text;
            string nombreHijo = NombreHijoTexto.Text;
            Departamento departamento = (Departamento) DropDownDepartamento.SelectedItem;

            if((usuario == "") || (nombre == "") || (telefono == "") || (nombreHijo == ""))
            {
                MessageBox.Show("Llene los datos correctamente");
                return;
            }
            else if(Cliente.UsuarioExistente(usuario))
            {
                MessageBox.Show("Usuario ya existente");
                return;
            }

            CrearNuevoCliente(usuario, nombre, telefono, email, nombreHijo, departamento);
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

                PantallaConsultaCliente pantallaConsulta = new PantallaConsultaCliente(clienteSeleccionado);

                pantallaConsulta.Show();
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

            ClienteTabla.Rows.Clear();
            DisplayCliente(usuarioConsulta);
        }
        private void CrearDepartamentoDropDown()
        {
            DropDownDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
        }

        private void CrearNuevoCliente(string usuario, string nombre, string telefono, string email, string nombreHijo, Departamento departamento)
        {
            Hijo hijo = new Hijo(departamento, nombreHijo);
            Cliente nuevoCliente = new Cliente(usuario, nombre, telefono, email, hijo);

            UsuarioTexto.Clear();
            NombreTexto.Clear();
            TelefonoTexto.Clear();
            EmailTexto.Clear();
            NombreHijoTexto.Clear();

            ClienteTabla.Rows.Clear();
            DisplayClientes();

            MessageBox.Show("Nuevo cliente creado con exito");
        }

        private void DisplayClientes()
        {
            foreach (Cliente cliente in Cliente.ObtenerClientes())
            {
                DisplayCliente(cliente.ObtenerUsuario());
            }
        }

        private void DisplayCliente(string usuarioConsulta)
        {
            Cliente cliente = Cliente.ObtenerConUsuario(usuarioConsulta);

            if(cliente != null)
            {          
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
