using System;
using System.Collections.Generic;
using System.Data;
using Darkrainbowsprinkles.OracleAccess;

namespace ProyectoTienda.Clientes
{
    public class Cliente : IDataInserter, IDataModifier
    {
        // NOMBRES DE INSTANCIA

        public string CLIENTE_USUARIO { get; set; } = "";
        public string CLIENTE_NOMBRE { get; set; } = "";
        public string CLIENTE_TELEFONO { get; set; } = "";
        public string CLIENTE_EMAIL { get; set; } = "";
        public string CLIENTE_CREACION { get; set; } = "";
        public int CLIENTE_DEUDA { get; set; } = 0;

        // NOMBRES EN TABLA SQL DEVELOPER

        static readonly string tablaSQL = "CLIENTE";
        static readonly string usuarioSQL = "CLIENTE_USUARIO";
        static readonly string nombreSQL = "CLIENTE_NOMBRE";
        static readonly string telefonoSQL = "CLIENTE_TELEFONO";
        static readonly string emailSQL = "CLIENTE_EMAIL";
        static readonly string creacionSQL = "CLIENTE_CREACION";
        static readonly string deudaSQL = "CLIENTE_DEUDA";

        public Cliente() { }

        public Cliente(string clienteUsuario, string clienteNombre, string clienteEmail, string clienteTelefono)
        {
            CLIENTE_USUARIO = clienteUsuario;
            CLIENTE_NOMBRE = clienteNombre;
            CLIENTE_EMAIL = clienteEmail;
            CLIENTE_TELEFONO = clienteTelefono;

            CLIENTE_CREACION = DateTime.Now.ToString();
        }

        // STATE GLOBAL DE CLASE

        public static DataTable ObtenerTablaFiltradaDeClientes()
        {
            DataView dataView = new DataView(DataBaseManager.GetDataTable(tablaSQL));
            DataTable tablaFiltrada = dataView.ToTable(false, usuarioSQL, nombreSQL, telefonoSQL);
            return tablaFiltrada;
        }

        public static string ObtenerColumnaLlave()
        {
            return usuarioSQL;
        }

        public static Cliente ObtenerNuevoConUsuario(string usuario)
        {
            return DataBaseManager.GetItemWithKey<Cliente>(tablaSQL, usuarioSQL, usuario);
        }

        public static bool ChecarUsuarioExistente(string clienteUsuario)
        {
            return (DataBaseManager.AlreadyHasKey(tablaSQL, usuarioSQL, clienteUsuario));
        }

        public static int MaxCapacidadUsuario()
        {
            return DataBaseManager.GetMaxAttributeSize(tablaSQL, usuarioSQL);
        }

        public static int MaxCapacidadNombre()
        {
            return DataBaseManager.GetMaxAttributeSize(tablaSQL, nombreSQL);
        }

        public static int MaxCapacidadTelefono()
        {
            return DataBaseManager.GetMaxAttributeSize(tablaSQL, telefonoSQL);
        }

        public static int MaxCapacidadEmail()
        {
            return DataBaseManager.GetMaxAttributeSize(tablaSQL, emailSQL);
        }

        // STATE PUBLICO DE INSTANCIA

        public bool AplicarInsercion()
        {
            return DataBaseManager.InsertData(this);
        }

        public bool AplicarModificaciones()
        {
            return DataBaseManager.ModifyData(this);
        }

        public bool RemoverEsteCliente()
        {
            return DataBaseManager.DeleteItemWithKey(tablaSQL, usuarioSQL, CLIENTE_USUARIO);
        }

        // INSERCION A BASE DE DATOS

        string IDataInserter.GetInsertionTableName()
        {
            return tablaSQL;
        }

        string IDataInserter.GetInsertionWhereClause()
        {
            return $"{usuarioSQL} = {usuarioSQL}";
        }

        Dictionary<string, object> IDataInserter.GetInsertionData()
        {
            return new Dictionary<string, object>
            {
                { usuarioSQL, CLIENTE_USUARIO },
                { nombreSQL, CLIENTE_NOMBRE },
                { telefonoSQL, CLIENTE_TELEFONO },
                { emailSQL, CLIENTE_EMAIL },
                { creacionSQL, CLIENTE_CREACION },
                { deudaSQL, CLIENTE_DEUDA }
            };
        }

        // MODIFICACION A BASE DE DATOS

        string IDataModifier.GetModifyingTableName()
        {
            return tablaSQL;
        }

        string IDataModifier.GetModifyingWhereClause()
        {
            return $"{usuarioSQL} =: {usuarioSQL}";
        }

        Dictionary<string, object> IDataModifier.GetDataToModify()
        {
            return new Dictionary<string, object>
            {
                { usuarioSQL, CLIENTE_USUARIO },
                { nombreSQL, CLIENTE_NOMBRE },
                { telefonoSQL, CLIENTE_TELEFONO },
                { emailSQL, CLIENTE_EMAIL },
                { creacionSQL, CLIENTE_CREACION },
                { deudaSQL, CLIENTE_DEUDA }
            };
        }
    }
}
