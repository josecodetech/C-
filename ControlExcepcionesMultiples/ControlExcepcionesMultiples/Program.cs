using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepcionesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce un numero: ");
                int numero = int.Parse(Console.ReadLine());
                int resultado = 10 / numero;
                Console.WriteLine($"Resultado: {resultado}");
                string contenido = File.ReadAllText("archivo.txt");
                Console.WriteLine(contenido);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division entre cero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Formato de numero no valido.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: El archivo no existe");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Proceso finalizado");
            }
        }
    }
}
