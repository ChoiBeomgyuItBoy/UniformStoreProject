using Darkrainbowsprinkles.OracleAccess;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProyectoTienda.Inventario
{
    public class Producto : IDataInserter, IDataModifier
    {
        // NOMBRES DE INSTANCIA

        public string PRODUCTO_NOMBRE { get; set; } = "";
        public ProductoCategoria PRODUCTO_CATEGORIA { get; set; } = default;
        public int PRODUCTO_STOCK { get; set; } = 0;
        public float PRODUCTO_PRECIO { get; set; } = 0;
        public string PRODUCTO_CREACION { get; set; } = "";

        // NOMBRES EN TABLA SQL DEVELOPER

        static readonly string tablaSQL = "PRODUCTO";
        static readonly string nombreSQL = "PRODUCTO_NOMBRE";
        static readonly string categoriaSQL = "PRODUCTO_CATEGORIA";
        static readonly string stockSQL = "PRODUCTO_STOCK";
        static readonly string precioSQL = "PRODUCTO_PRECIO";
        static readonly string creacionSQL = "PRODUCTO_CREACION";

        public Producto() { }

        public Producto(string productoNombre, ProductoCategoria productoCategoria, int productoStock, float productoPrecio)
        {
            PRODUCTO_NOMBRE = productoNombre;
            PRODUCTO_CATEGORIA = productoCategoria;
            PRODUCTO_STOCK = productoStock;
            PRODUCTO_PRECIO = productoPrecio;

            PRODUCTO_CREACION = DateTime.Now.ToString();
        }

        // STATE GLOBAL DE CLASE

        public static DataTable ObtenerTablaFiltradaDeProductos()
        {
            DataView dataView = new DataView(DataBaseManager.GetDataTable(tablaSQL));
            DataTable tablaFiltrada = dataView.ToTable(false, nombreSQL, categoriaSQL, precioSQL);
            return tablaFiltrada;
        }

        public static bool ChecarNombreExistente(string nombre)
        {
            return DataBaseManager.AlreadyHasKey(tablaSQL, nombreSQL, nombre);
        }

        public static int MaxCapacidadNombre()
        {
            return DataBaseManager.GetMaxAttributeSize(tablaSQL, nombreSQL);
        }

        public static int MaxCapacidadStock()
        {
            return DataBaseManager.GetMaxAttributeSize(tablaSQL, stockSQL);
        }

        public static int MaxCapacidadPrecio()
        {
            return DataBaseManager.GetMaxAttributeSize(tablaSQL, precioSQL);
        }

        public static string ObtenerColumnaCategoria()
        {
            return categoriaSQL;
        }

        public static Producto ObtenerNuevoConNombre(string nombre)
        {
            return DataBaseManager.GetItemWithKey<Producto>(tablaSQL, nombreSQL, nombre);
        }

        // STATE PUBLICO DE INSTANCIA

        public bool AplicarInsercion()
        {
            return DataBaseManager.InsertData(this);
        }

        public bool AplicarModificacion()
        {
            return DataBaseManager.ModifyData(this);
        }

        public bool RemoverEsteProducto()
        {
            return DataBaseManager.DeleteItemWithKey(tablaSQL, nombreSQL, PRODUCTO_NOMBRE);
        }

        // INSERCION A BASE DE DATOS

        string IDataInserter.GetInsertionTableName()
        {
            return tablaSQL;
        }

        string IDataInserter.GetInsertionWhereClause()
        {
            return $"{nombreSQL} = {nombreSQL}";
        }

        Dictionary<string, object> IDataInserter.GetInsertionData()
        {
            return new Dictionary<string, object>
            {
                { nombreSQL, PRODUCTO_NOMBRE },
                { categoriaSQL, PRODUCTO_CATEGORIA.ToString() },
                { stockSQL, PRODUCTO_STOCK },
                { precioSQL, PRODUCTO_PRECIO },
                { creacionSQL, PRODUCTO_CREACION }
            };
        }
        
        // MODIFICACION A BASE DE DATOS    

        public string GetModifyingTableName()
        {
            return tablaSQL;
        }

        public string GetModifyingWhereClause()
        {
            return $"{nombreSQL} =: {nombreSQL}";
        }

        public Dictionary<string, object> GetDataToModify()
        {
            return new Dictionary<string, object>
            {
                { nombreSQL, PRODUCTO_NOMBRE },
                { categoriaSQL, PRODUCTO_CATEGORIA.ToString() },
                { stockSQL, PRODUCTO_STOCK },
                { precioSQL, PRODUCTO_PRECIO },
                { creacionSQL, PRODUCTO_CREACION }
            };
        }
    }
}
