using System;
using System.Windows.Forms;
using ProyectoTienda.Gerentes;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void UsuarioInput_TextChanged(object sender, EventArgs e) { }

        private void ContraseñaInput_TextChanged(object sender, EventArgs e) { }

        private void BotonAcceso_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioInput.Text;
            string claveAcceso = ContraseñaInput.Text;

            if(!Gerente.ExisteGerente(usuario))
            {
                MessageBox.Show("Usuario o contraseña invalidos");
            }
            else
            {
                Hide();
                PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                pantallaPrincipal.Show();
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
