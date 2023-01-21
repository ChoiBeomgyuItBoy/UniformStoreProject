using System;
using System.Collections.Generic;

namespace ProyectoTienda.Gerentes
{
    public class Gerente
    {
        private string usuario;
        private string claveAcceso;

        private static Dictionary<string, Gerente> gerentes = new Dictionary<string, Gerente>();

        public Gerente(string nombreUsuario, string claveAcceso)
        {
            this.usuario = nombreUsuario;
            this.claveAcceso = claveAcceso;

            gerentes[this.usuario] = this;
        }

        // GETTERS

        public string ObtenerUsuario() => usuario;
        public string ObtenerClave() => claveAcceso;

        // STATIC METHODS
        
        public static Gerente ObtenerConUsuario(string nombreUsuario)
        {
            return gerentes[nombreUsuario];
        }

        public static void CrearGerentesIniciales()
        {
            Gerente gerente = new Gerente("Manager", "12345");
        }

        public static bool ExisteGerente(string nombreUsuario)
        {
            return gerentes.ContainsKey(nombreUsuario);
        }
    }
}
