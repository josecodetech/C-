using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int divisor = 0;
                int resultado = 10 / divisor;
                Console.WriteLine($"Resultado = {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: No se puede dividir por cero. Excepcion = {ex}");
            }
            finally
            {
                Console.WriteLine("Finalizado el calculo.");
            }

        }
    }
}
