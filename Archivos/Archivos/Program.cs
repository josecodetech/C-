using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string archivo = "archivo_texto.txt";
            // escritura
            using (StreamWriter writer = new StreamWriter(archivo)) {
                writer.WriteLine("Linea 1: Hola, este es un archivo de texto.");
                writer.WriteLine("Linea 2: C# facilita la escritura en archivos.");
                writer.WriteLine("Linea 3: Esta es la ultima linea.");
            }
            Console.WriteLine("Texto escrito en el archivo correctamente.");
            // lectura
            using (StreamReader reader = new StreamReader(archivo)) {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            Console.WriteLine("Texto leido correctamente");
            // escritura de binarios
            string archivoBinario = "archivo_binario.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(archivoBinario, FileMode.Create)))
            {
                writer.Write(100);
                writer.Write(3.14);
                writer.Write("Hola, desde fichero binario");
            }
            Console.WriteLine("Datos binarios escritos en archivo");
            // lectura de binario
            using (BinaryReader reader = new BinaryReader(File.Open(archivoBinario, FileMode.Open)))
            {
                int entero = reader.ReadInt32();
                double decimalNum = reader.ReadDouble();
                string cadena = reader.ReadString();
                Console.WriteLine($"Entero: {entero}, Decimal: {decimalNum}, Cadena: {cadena}");
            }
            // clase File
            string original = "archivo_texto.txt";
            string copia = "archivo_copia.txt";
            // verificar si existe
            if (File.Exists(original))
            {
                // copia
                File.Copy(original, copia, true);
                Console.WriteLine("Archivo copiado");
                // mueve
                string nuevo = "archivo_movido.txt";
                File.Move(original, nuevo);
                Console.WriteLine("Archivo movido");
                // elimina
                File.Delete(original);
                Console.WriteLine("Archivo eliminado");

            } else
            {
                Console.WriteLine("El archivo no existe");
            }
        }
    }
}
