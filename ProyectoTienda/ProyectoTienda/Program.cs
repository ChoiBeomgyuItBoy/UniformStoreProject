using System;
using System.Windows.Forms;
using ProyectoTienda.Pantallas;

namespace ProyectoTienda
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SingletonPantallas pantallas = new SingletonPantallas();
            //Application.Run(new PantallaPrincipal());
            Application.Run(new PantallaLogin());
        }
    }
}
