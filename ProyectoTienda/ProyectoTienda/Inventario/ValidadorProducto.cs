using System;

namespace ProyectoTienda.Inventario
{
    public static class ValidadorProducto
    {
        public static bool ValidarInsercion(string nombre, string categoriaTexto, out ProductoCategoria categoriaEnum, string stockTexto, out int stockNumero, string precioTexto, out float precioNumero)
        {
            stockNumero = 0;
            precioNumero = 0;
            categoriaEnum = default;

            if(nombre == "" || categoriaTexto == "" || stockTexto == "" || precioTexto == "")
            {
                return false;
            }

            if(Producto.ChecarNombreExistente(nombre))
            {
                Utils.MessageBoxes.ShowErrorBox($"Nombre ya existente");
                return false;
            }

            if (nombre.Length > Producto.MaxCapacidadNombre())
            {
                Utils.MessageBoxes.ShowErrorBox($"Nombre no debe ser mayor a {Producto.MaxCapacidadNombre()}");
                return false;
            }

            if(!EsCategoria(categoriaTexto, out categoriaEnum))
            {
                Utils.MessageBoxes.ShowErrorBox("Categoria invalida");
                return false;
            }

            if(!EsInt(stockTexto, out stockNumero))
            {
                Utils.MessageBoxes.ShowErrorBox("Stock invalido");
                return false;
            }

            if(!EsFloat(precioTexto, out precioNumero))
            {
                Utils.MessageBoxes.ShowErrorBox("Precio invalido");
                return false;
            }

            return true;
        }

        public static bool ValidarModificacion(string categoriaTexto, out ProductoCategoria categoriaEnum, string stockTexto, out int stockNumero, string precioTexto, out float precioNumero)
        {
            stockNumero = 0;
            precioNumero = 0;
            categoriaEnum = default;

            if (categoriaTexto == "" || stockTexto == "" || precioTexto == "")
            {
                return false;
            }

            if (!EsCategoria(categoriaTexto, out categoriaEnum))
            {
                Utils.MessageBoxes.ShowErrorBox("Categoria invalida");
                return false;
            }

            if (!EsInt(stockTexto, out stockNumero))
            {
                Utils.MessageBoxes.ShowErrorBox("Stock invalido");
                return false;
            }

            if (!EsFloat(precioTexto, out precioNumero))
            {
                Utils.MessageBoxes.ShowErrorBox("Precio invalido");
                return false;
            }

            return true;
        }

        public static bool EsCategoria(string categoriaAChecar, out ProductoCategoria categoria)
        {
            if (!Enum.TryParse(categoriaAChecar, out categoria))
            {
                return false;
            }

            return true;
        }

        private static bool EsInt(string numeroAChecar, out int numero)
        {
            if (!int.TryParse(numeroAChecar, out numero))
            {
                return false;
            }

            return true;
        }

        private static bool EsFloat(string numeroAChecar, out float numero)
        {
            if(!float.TryParse(numeroAChecar, out numero))
            {
                return false;
            }

            return true;
        }
    }
}
