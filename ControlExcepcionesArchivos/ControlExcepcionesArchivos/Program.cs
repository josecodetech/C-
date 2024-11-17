using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepcionesArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string contenido = File.ReadAllText("archivo_inexistente.txt");
                Console.WriteLine(contenido);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: El archivo no existe.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex.Message}");
            }
         
            finally
            {
                Console.WriteLine("Intento de lectura de archivo finalizado.");
            }
        }
    }
}
