using System;
using System.Windows.Forms;
using ProyectoTienda.Gerentes;
using ProyectoTienda.Utils;

namespace ProyectoTienda.Pantallas
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            Gerente.CrearGerentesIniciales();

            WindowState = FormWindowState.Maximized;
        }

        private void MostrarSubPantalla(object pantalla)
        {
            if (PanelContenedor.Controls.Count > 0)
            {
                PanelContenedor.Controls.RemoveAt(0);
            }

            Form subPantalla = pantalla as Form;

            subPantalla.TopLevel = false;
            subPantalla.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(subPantalla);
            PanelContenedor.Tag = subPantalla;

            subPantalla.Show();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BotonMaximizar_Click(object sender, EventArgs e)
        {
             WindowState = FormWindowState.Maximized;
             BotonMaximizar.Visible = false;
             BotonRestaurar.Visible = true;
        }

        private void BotonRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            BotonMaximizar.Visible = true;
            BotonRestaurar.Visible = false;
        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            MostrarSubPantalla(new PantallaClientes());
        }

        private void BotonInventario_Click(object sender, EventArgs e)
        {
            MostrarSubPantalla(new PantallaInventario());
        }

        private void BotonCompra_Click(object sender, EventArgs e)
        {
            MostrarSubPantalla(new PantallaCompra());
        }

        private void BotonVentas_Click(object sender, EventArgs e)
        {
            MostrarSubPantalla(new PantallaVentas());
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowDragging.ApplyWindowDragging(this);
        }
    }
}
