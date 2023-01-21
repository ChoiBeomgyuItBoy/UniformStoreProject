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

            Cliente nuevoCliente = new Cliente(usuario, nombre, telefono, email);

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

        private void ClienteTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
