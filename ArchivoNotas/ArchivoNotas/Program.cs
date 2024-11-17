using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string archivo = "notas.txt";
            using (StreamWriter writer = new StreamWriter(archivo)) {
                writer.WriteLine("Nota 1: Aprobado");
                writer.WriteLine("Nota 2: Sobresaliente");
                writer.WriteLine("Nota 3: Suspenso");
            }
            Console.WriteLine("Notas guardadas en el archivo.");

            using (StreamReader reader = new StreamReader(archivo))
            {
                Console.WriteLine("Contenido del archivo de notas: ");
                string linea;
                while ((linea = reader.ReadLine()) != null) { 
                Console.WriteLine(linea);
                }
            }
            Console.WriteLine("Fichero leido correctamente");
        }
    }
}
