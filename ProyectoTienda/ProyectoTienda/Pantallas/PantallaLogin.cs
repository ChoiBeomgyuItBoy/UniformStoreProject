using ProyectoTienda.Usuarios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
            AjustarAlfaDeImagen();
        }

        // UTILIDADES

        private void AjustarAlfaDeImagen()
        {
            Logo.BackColor = Color.FromArgb(127, Logo.BackColor);
        }

        private void Accesar()
        {
            Hide();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
        }

        // EVENTOS DE INPUT

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonAcceso_Click(object sender, EventArgs e)
        {
            string ID = IDTexto.Text;
            string clave = ClaveTexto.Text;

            if (ID == "" || clave == "") return;

            if(Usuario.ChecarIDExistente(ID))
            {
                Usuario usuario = Usuario.ObtenerNuevoConID(ID);

                if(usuario != null && usuario.USUARIO_CLAVE == clave)
                {
                    Utils.MessageBoxes.ShowSuccessBox("Acceso Garantizado");
                    Accesar();
                }
            }
            else
            {
                Utils.MessageBoxes.ShowErrorBox("Clave o Usuario incorrectos");
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Utils.WindowDragging.ApplyWindowDragging(this);
        }
    }
}
