using System;

namespace ProyectoTienda.Clientes
{
    public class Hijo
    {
        public Departamento? departamento = null;
        public string nombre = "";

        public Hijo(Departamento departamento, string nombre)
        {
            this.departamento = departamento;
            this.nombre = nombre;
        }
    }
}
