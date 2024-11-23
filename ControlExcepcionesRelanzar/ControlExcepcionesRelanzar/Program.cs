using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepcionesRelanzar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dividir(10, 1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error manejado en Main: {ex.Message}");
            }
        }
        static void Dividir(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("No se puede dividir entre cero.");
                }
                Console.WriteLine($"Resultado: {a / b}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Excepcion capturada en Dividir.");
                throw;
            }
        }
    }
}

