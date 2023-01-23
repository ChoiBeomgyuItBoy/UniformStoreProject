using ProyectoTienda.Clientes;
using ProyectoTienda.Utils;
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
    public partial class PantallaConsultaCliente : Form
    {
        private Cliente cliente;

        public PantallaConsultaCliente(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            DisplayCliente();
            DisplayHijos();
        }

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

        private void BotonEditar_Click(object sender, EventArgs e)
        {

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowDragging.ApplyWindowDragging(this);
        }
    }
}
