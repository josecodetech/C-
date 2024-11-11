using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseProducto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto miProducto = new Producto();
            miProducto.Nombre = "Laptop";
            miProducto.Precio = 1500.65m;
            miProducto.Descuento = 10;
            Console.WriteLine($"El precio final de {miProducto.Nombre} es {miProducto.CalcularPrecioFinal()}");
        }
    }
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal CalcularPrecioFinal()
        {
            return Precio - (Precio * (Descuento / 100));
        }
    }
}
