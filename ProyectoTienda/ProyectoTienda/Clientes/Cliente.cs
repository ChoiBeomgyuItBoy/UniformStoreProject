using System;
using System.Collections.Generic;

namespace ProyectoTienda.Clientes
{
    public class Cliente
    {
        private string usuario = "";
        private string nombreCliente = "";
        private string telefono = "";
        private string email = "";

        // TO USE
        private string fechaCreacion = "";
        private float deuda = 0;

        private List<Hijo> hijos = new List<Hijo>();

        private static Dictionary<string, Cliente> clientes = new Dictionary<string, Cliente>();
        
        public Cliente(string usuario, string nombreCliente, string telefono, string email, Hijo hijo)
        {
            this.usuario = usuario;
            this.nombreCliente = nombreCliente;
            this.telefono = telefono;
            this.email = email;

            hijos.Add(hijo);

            this.fechaCreacion = DateTime.Today.ToString();

            clientes[usuario] = this;
        }

        // GETTERS

        public string ObtenerUsuario() => usuario;
        public string ObtenerNombre() => nombreCliente;
        public string ObtenerEmail() => email;
        public string ObtenerTelefono() => telefono;
        public string ObtenerFechaCreacion() => fechaCreacion;
        public float ObtenerDeuda() => deuda;

        public IEnumerable<Hijo> ObtenerHijos()
        {
            foreach (Hijo hijo in hijos)
            {
                yield return hijo;
            }
        }

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
