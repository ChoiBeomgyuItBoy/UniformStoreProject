using ProyectoTienda.Clientes;
using ProyectoTienda.Inventario;
using System.Collections.Generic;
using System;
using System.Data;

namespace ProyectoTienda.Compras
{
    public class Compra
    {
        List<Producto> productos = new List<Producto>();

        float total = 0;

        public List<Producto> ObtenerListaDeProductos()
        {
            if (productos.Count == 0) return null;

            return productos;
        }

        public float ObtenerTotal()
        {
            return total;
        }

        public void Agregar(Producto producto)
        {
            productos.Add(producto);

            total += producto.PRODUCTO_PRECIO;
        }
    }
}