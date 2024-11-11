using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEmpleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Jose = new Empleado();
            Jose.Nombre = "Jose";
            Jose.SalarioBase = 1700.10m;
            Jose.Antiguedad = 24;
            Console.WriteLine($"El bono de {Jose.Nombre} es {Jose.CalcularBono()}");
        }
    }
    public class Empleado
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public int Antiguedad { get; set; }
        public decimal CalcularBono()
        {
            return SalarioBase * (0.05m * Antiguedad);
        }
    }
}
