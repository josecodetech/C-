using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepcionesPersonalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ValidarEdad(20);
            }
            catch (EdadInvalidaException ex) { 
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void ValidarEdad(int edad)
        {
            if (edad < 0 || edad > 110)
            {
                throw new EdadInvalidaException("La edad ingresada no es valida.");
            }
            Console.WriteLine($"Edad valida: {edad}");
        }
    }
    class EdadInvalidaException : Exception { 
        public EdadInvalidaException(string mensaje) :base(mensaje) { 
        
        }
    }
}
