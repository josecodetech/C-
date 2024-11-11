using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            Console.WriteLine("Ingresa el radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());
            double area = PI * radio * radio;
            Console.WriteLine($"El area del circulo con radio = {radio} es {area}");
        }
    }
}
