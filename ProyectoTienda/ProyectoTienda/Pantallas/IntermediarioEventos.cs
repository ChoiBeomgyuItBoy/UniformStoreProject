﻿using ProyectoTienda.Clientes;
using ProyectoTienda.Inventario;
using System;

namespace ProyectoTienda.Pantallas
{
    public static class IntermediarioEventos
    {
        public static event Action<Producto> productoAgregado;

        public static event Action<Cliente> compraIniciada;

        public static event Action compraCancelada;

        public static event Action<Cliente, int, float> compraFinalizada;

        static bool compraActiva = false;

        public static bool CompraActiva()
        {
            return compraActiva;
        }

        public static void IniciarCompra(Cliente cliente)
        {
            compraIniciada?.Invoke(cliente);
            compraActiva = true;
        }

        public static void CancelarCompra()
        {
            compraCancelada?.Invoke();
            compraActiva = false;
        }

        public static void AgregarProducto(Producto producto)
        {
            productoAgregado?.Invoke(producto);
        }

        public static void FinalizarCompra(Cliente cliente, int cantidad, float total)
        {
            compraFinalizada?.Invoke(cliente, cantidad, total);
        }
    }
}
