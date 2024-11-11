using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero entero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El numero {numero} es par.");
            }
            else {
                Console.WriteLine($"El numero {numero} es impar.");
            }
        }
    }
}
