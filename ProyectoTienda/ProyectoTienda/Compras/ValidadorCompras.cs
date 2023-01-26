using System;

namespace ProyectoTienda.Compras
{
    public static class ValidadorCompras
    {
        public static bool ValidarPagoEfectivo(string cantidadTexto, out int cantidadNumero)
        {
            cantidadNumero = 0;

            if(cantidadTexto == "")
            {
                return false;
            }

            if(!EsInt(cantidadTexto, out cantidadNumero))
            {
                Utils.MessageBoxes.ShowErrorBox($"Cantidad invalida");
                return false;
            }

            if(cantidadNumero > 10000)
            {
                Utils.MessageBoxes.ShowErrorBox($"Cantidad demasiado larga");
                return false;
            }

            return true;

        }

        public static bool ValidarPagoConTarjeta(string nombreTarjeta, string numeroTarjeta, string CVV)
        {
            if(nombreTarjeta == "" || numeroTarjeta == "" || CVV == "")
            {
                return false;
            }
            
            if(nombreTarjeta.Length > 100)
            {
                Utils.MessageBoxes.ShowErrorBox($"Nombre demasiado largo");
                return false;
            }

            if(!EsInt(numeroTarjeta))
            {
                Utils.MessageBoxes.ShowErrorBox($"Numero de tarjeta invalido");
                return false;
            }

            if(!EsInt(CVV))
            {
                Utils.MessageBoxes.ShowErrorBox($"CVV invalido");
                return false;
            }

            if(numeroTarjeta.Length > 16)
            {
                Utils.MessageBoxes.ShowErrorBox($"Numero tarjeta no debe ser mayor a 16 digitos");
                return false;
            }

            if(CVV.Length > 4)
            {
                Utils.MessageBoxes.ShowErrorBox($"CVV no debe ser mayor a 4 digitos");
                return false;
            }

            return true;
        }

        private static bool EsInt(string numeroAChecar)
        {
            int num = 0;

            if (!int.TryParse(numeroAChecar, out num))
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
    }
}
