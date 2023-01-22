using System.Collections.Generic;

namespace ProyectoTienda.Clientes
{
    public class Cliente
    {
        private string usuario;
        private string nombreCliente;
        private string telefono;
        private string email;

        private static Dictionary<string, Cliente> clientes = new Dictionary<string, Cliente>();
        
        public Cliente(string usuario, string nombreCliente, string telefono, string email)
        {
            this.usuario = usuario;
            this.nombreCliente = nombreCliente;
            this.telefono = telefono;
            this.email = email;

            clientes[usuario] = this;
        }

        // GETTERS

        public string ObtenerUsuario() => usuario;
        public string ObtenerNombre() => nombreCliente;
        public string ObtenerEmail() => email;
        public string ObtenerTelefono() => telefono;

        // STATIC METHODS

        public static Cliente ObtenerConUsuario(string usuario)
        {
            return clientes[usuario];
        }

        public static IEnumerable<Cliente> ObtenerClientes()
        {
            foreach(KeyValuePair<string, Cliente> cliente in clientes)
            {
                yield return cliente.Value;
            }
        }

        public static bool UsuarioExistente(string usuario)
        {
            return clientes.ContainsKey(usuario);
        }
    }
}
