using System;


namespace ProyectoTienda.Clientes
{
    public static class ValidadorCliente
    {
        public static bool ValidarInsercion(string usuario, string nombre, string email, string telefono)
        {
            if (usuario == "" || nombre == "" || email == "" || telefono == "")
            {
                return false;
            }

            if (Cliente.ChecarUsuarioExistente(usuario))
            {
                Utils.MessageBoxes.ShowErrorBox($"Usuario ya existente");
                return false;
            }

            if (usuario.Length > Cliente.MaxCapacidadUsuario())
            {
                Utils.MessageBoxes.ShowErrorBox($"Usuario no debe ser mayor a {Cliente.MaxCapacidadUsuario()}");
                return false;
            }

            if (nombre.Length > Cliente.MaxCapacidadNombre())
            {
                Utils.MessageBoxes.ShowErrorBox($"Nombre no debe ser mayor a {Cliente.MaxCapacidadNombre()}");
                return false;
            }

            if (email.Length > Cliente.MaxCapacidadEmail())
            {
                Utils.MessageBoxes.ShowErrorBox($"Email no debe ser mayor a {Cliente.MaxCapacidadEmail()}");
                return false;
            }

            int telefonoNumero = 0;

            bool esNumero = int.TryParse(telefono, out telefonoNumero);

            if (!esNumero)
            {
                Utils.MessageBoxes.ShowErrorBox($"Telefono invalido");
                return false;
            }

            return true;
        }

        public static bool ValidarModificacion(string nombre, string email, string telefono)
        {
            if (nombre.Length > Cliente.MaxCapacidadNombre())
            {
                Utils.MessageBoxes.ShowErrorBox($"Nombre no debe ser mayor a {Cliente.MaxCapacidadNombre()}");
                return false;
            }
            else if (email.Length > Cliente.MaxCapacidadEmail())
            {
                Utils.MessageBoxes.ShowErrorBox($"Email no debe ser mayor a {Cliente.MaxCapacidadEmail()}");
                return false;
            }
            else if (telefono.Length > Cliente.MaxCapacidadTelefono())
            {
                Utils.MessageBoxes.ShowErrorBox($"Telefono no debe ser mayor a {Cliente.MaxCapacidadTelefono()}");
                return false;
            }

            int telefonoNumero = 0;

            bool esNumero = int.TryParse(telefono, out telefonoNumero);

            if(!esNumero)
            {
                Utils.MessageBoxes.ShowErrorBox($"Telefono invalido");
                return false;
            }

            return true;
        }
    }
}
