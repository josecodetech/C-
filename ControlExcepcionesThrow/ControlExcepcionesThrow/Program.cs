using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepcionesThrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //throw new Exception("Mensaje");
            try
            {
                ValidarNumero(5);
            }
            catch (ArgumentException ex){ 
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void ValidarNumero(int numero)
        {
            if (numero < 0) {
                throw new ArgumentException("El numero no puede ser negativo.");
            }
            Console.WriteLine($"Numero valido: {numero}");
           
        }

    }

}
