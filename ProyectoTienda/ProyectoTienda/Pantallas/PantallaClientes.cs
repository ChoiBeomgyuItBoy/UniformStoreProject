using ProyectoTienda.Clientes;
using ProyectoTienda.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaClientes : Form
    {
        private const int indexColumnaUsuarios = 0;

        public PantallaClientes()
        {
            InitializeComponent();
        }

        // INICIALIZACION

        private void PantallaClientes_Load(object sender, EventArgs e)
        {
            PantallaConsultaCliente.informacionActualizada += DisplayClientes;
           
            DisplayClientes();
            LlenarDropDownDeDepartamentos();
        }

        // UTILIDADES

        private void DisplayClientes()
        {
            DataTable tablaClientes = Cliente.ObtenerTablaFiltradaDeClientes();

            ClienteTabla.DataSource = tablaClientes;
        }

        private void LlenarDropDownDeDepartamentos()
        {
            DropDownDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
            DropDownDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FiltrarPorUsuario(string usuario)
        {
            var datoFiltrado = Cliente.ObtenerTablaFiltradaDeClientes().AsEnumerable()
                               .Where(row => row.Field<string>(Cliente.ObtenerColumnaLlave()) == usuario);

            ClienteTabla.DataSource = datoFiltrado.AsDataView();
        }

        // EVENTOS DE INPUT

        private void BotonNuevoCliente_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioTexto.Text;
            string nombre = NombreTexto.Text;
            string email = EmailTexto.Text;
            string telefono = TelefonoTexto.Text;

            if (ValidadorCliente.ValidarInsercion(usuario, nombre, email, telefono))
            {
                Cliente nuevoCliente = new Cliente(usuario, nombre, email, telefono);

                if (nuevoCliente != null && nuevoCliente.AplicarInsercion())
                {
                    MessageBoxes.ShowSuccessBox("Cliente creado con exito");

                    DisplayClientes();
                }
                else
                {
                    MessageBoxes.ShowErrorBox("Error al crear cliente");
                }
            }
        }

        private void ClienteTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celdaSeleccionada = ClienteTabla.CurrentCell;

            if(celdaSeleccionada != null)
            {
                if (celdaSeleccionada.RowIndex < 0) return;

                string datoCelda = celdaSeleccionada.Value.ToString();

                if (celdaSeleccionada.ColumnIndex != indexColumnaUsuarios) return;               
                
                Cliente clienteSeleccionado = Cliente.ObtenerNuevoConUsuario(datoCelda);

                if (clienteSeleccionado == null) return;

                PantallaConsultaCliente pantallaConsulta = new PantallaConsultaCliente(clienteSeleccionado);

                pantallaConsulta.Show();
            }        
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            string usuarioConsulta = ConsultaTexto.Text;

            if (usuarioConsulta == "") return;

            if(!Cliente.ChecarUsuarioExistente(usuarioConsulta))
            {
                MessageBoxes.ShowErrorBox($"Usuario no existente");
                return;
            }

            FiltrarPorUsuario(usuarioConsulta);
        }
    }
}
