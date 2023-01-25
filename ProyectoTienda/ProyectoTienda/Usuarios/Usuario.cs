using Darkrainbowsprinkles.OracleAccess;
using System;

namespace ProyectoTienda.Usuarios
{
    public class Usuario
    {
        // NOMBRES DE INSTANCIA

        public string USUARIO_ID { get; private set; } = "";
        public string USUARIO_CLAVE { get; private set; } = "";

        // NOMBRES EN TABLA SQL DEVELOPER

        static readonly string tablaSQL = "USUARIO";
        static readonly string IDSQL = "USUARIO_ID";

        // STATE GLOBAL DE CLASE

        public static bool ChecarIDExistente(string ID)
        {
            return DataBaseManager.AlreadyHasKey(tablaSQL, IDSQL, ID);
        }

        public static Usuario ObtenerNuevoConID(string ID)
        {
            return DataBaseManager.GetItemWithKey<Usuario>(tablaSQL, IDSQL, ID);
        }
    }
}
