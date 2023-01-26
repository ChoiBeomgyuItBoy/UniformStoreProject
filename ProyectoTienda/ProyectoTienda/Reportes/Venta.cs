using Darkrainbowsprinkles.OracleAccess;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProyectoTienda.Reportes
{
    public class Venta : IDataInserter
    {
        // NOMBRES DE INSTANCIA

        public string VENTA_ID { get; set; } = "";
        public string VENTA_CREACION { get; set; } = "";
        public string CLIENTE_USUARIO { get; set; } = "";
        public int VENTA_PRODUCTOS { get; set; } = 0;
        public float VENTA_TOTAL { get; set; } = 0;

        // NOMBRES EN TABLA SQL DEVELOPER

        static readonly string tablaSQL = "VENTA";
        static readonly string idSQL = "VENTA_ID";
        static readonly string creacionSQL = "VENTA_CREACION";
        static readonly string usuarioSQL = "CLIENTE_USUARIO";
        static readonly string productosSQL = "VENTA_PRODUCTOS";
        static readonly string totalSQL = "VENTA_TOTAL";

        public Venta() { }

        public Venta(string clienteUsuario, int ventaProductos, float ventaTotal)
        {
            VENTA_ID = System.Guid.NewGuid().ToString();
            VENTA_CREACION = DateTime.Now.ToString();

            CLIENTE_USUARIO = clienteUsuario;
            VENTA_PRODUCTOS = ventaProductos;
            VENTA_TOTAL = ventaTotal;
        }

        // STATE GLOBAL

        public static DataTable ObtenerTablaDeVentas()
        {
            return DataBaseManager.GetDataTable(tablaSQL);
        }

        public static Venta ObtenerConID(string ventaID)
        {
            return DataBaseManager.GetItemWithKey<Venta>(tablaSQL, idSQL, ventaID);
        }

        // STATE PUBLICO DE INSTANCIA

        public bool AplicarInsercion()
        {
            return DataBaseManager.InsertData(this);
        }

        public bool RemoverEstaVenta()
        {
            return DataBaseManager.DeleteItemWithKey(tablaSQL, idSQL, VENTA_ID);
        }

        // INSERCION A BASE DE DATOS

        string IDataInserter.GetInsertionTableName()
        {
            return tablaSQL;
        }

        string IDataInserter.GetInsertionWhereClause()
        {
            return $"{idSQL} = {idSQL}";
        }

        Dictionary<string, object> IDataInserter.GetInsertionData()
        {
            return new Dictionary<string, object>()
            {
                { idSQL, VENTA_ID },
                { creacionSQL, VENTA_CREACION },
                { usuarioSQL, CLIENTE_USUARIO },
                { productosSQL, VENTA_PRODUCTOS },
                { totalSQL, VENTA_TOTAL }
            };
        }
    }
}
