using System;

namespace ProyectoTienda.Pantallas
{
    /// <summary>
    /// Debe instanciarse antes del inicio del programa para
    /// conseguir instancias unicas de las pantallas deseadas
    /// </summary>
    public class SingletonPantallas
    {
        public static PantallaCompra pantallaCompra = null;
        public static PantallaClientes pantallaClientes = null;
        public static PantallaInventario pantallaInventario = null;
        public static PantallaVentas pantallaVentas = null;

        public SingletonPantallas()
        {
            CrearPantallas();
        }

        private void CrearPantallas()
        {
            if(pantallaCompra == null)
            {
                pantallaCompra = new PantallaCompra();
            }

            if(pantallaClientes == null)
            {
                pantallaClientes = new PantallaClientes();
            }

            if(pantallaInventario == null)
            {
                pantallaInventario = new PantallaInventario();
            }

            if(pantallaVentas == null)
            {
                pantallaVentas = new PantallaVentas();
            }
        }
    }
}
