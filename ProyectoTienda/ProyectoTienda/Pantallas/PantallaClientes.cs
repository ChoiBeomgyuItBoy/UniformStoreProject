using ProyectoTienda.Clientes;
using ProyectoTienda.Utils;
using System;
using System.Windows.Forms;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaClientes : Form
    {
        private const int indexColumnaUsuarios = 1;

        public PantallaClientes()
        {
            InitializeComponent();
      
            PantallaConsultaCliente.informacionActualizada += RefrescarClientes;
        }

        private void PantallaClientes_Load(object sender, EventArgs e)
        {
            Cliente.CrearClientesParaDebug();
            DisplayClientes();
            CrearDepartamentoDropDown();
        }

        // FUNCTIONALITY

        private void CrearDepartamentoDropDown()
        {
            DropDownDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
        }

        private void RefrescarClientes()
        {
            ClienteTabla.Rows.Clear();
            DisplayClientes();
        }

        private void RefrescarTexto()
        {
            UsuarioTexto.Clear();
            NombreTexto.Clear();
            TelefonoTexto.Clear();
            EmailTexto.Clear();
            NombreHijoTexto.Clear();
        }

        private void CrearNuevoCliente(string usuario, string nombre, string telefono, string email, string nombreHijo, Departamento departamento)
        {
            Hijo hijo = new Hijo(departamento, nombreHijo);
            Cliente nuevoCliente = new Cliente(usuario, nombre, telefono, email, hijo);

            RefrescarTexto();
            RefrescarClientes();

            MessageBoxes.ShowSuccessBox("Nuevo cliente creado con exito");
        }

        private void DisplayClientes()
        {
            foreach (Cliente cliente in Cliente.ObtenerClientes())
            {
                DisplayCliente(cliente);
            }
        }

        private void DisplayCliente(Cliente cliente)
        {
            if (cliente == null) return;

            ClienteTabla.Rows.Add
            (
               cliente.ObtenerNombre(),
               cliente.ObtenerUsuario(),
               cliente.ObtenerEmail(),
               cliente.ObtenerTelefono()
            );
        }

        // INPUT EVENTS

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
                MessageBoxes.ShowErrorBox("Llene los datos correctamente");
                return;
            }
            else if(Cliente.UsuarioExistente(usuario))
            {
                MessageBoxes.ShowErrorBox("Usuario ya existente");
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
            else if(usuarioConsulta != "" && Cliente.UsuarioExistente(usuarioConsulta))
            {
                ClienteTabla.Rows.Clear();
                Cliente cliente = Cliente.ObtenerConUsuario(usuarioConsulta);
                DisplayCliente(cliente);
            }
            else
            {
                MessageBoxes.ShowErrorBox("Usuario no existente");
                return;
            }
        }
    }
}
