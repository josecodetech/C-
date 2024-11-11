using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaParesIntervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int suma = SumarPares(num1, num2);
            Console.WriteLine($"La suma de los numeros pares entre {num1} y {num2} es = {suma}");
        }

        private static int SumarPares(int inicio, int fin)
        {
            int suma = 0;
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }
    }
}
