using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracion de array
            // tipo[] nombreArray = new tipo[tamaño];
            int[] numeros = new int[5]; // declaramos array con 5 elementos
            int[] numeros2 = { 1, 2, 3, 4, 5 }; // con valores iniciales
            int[] numeros3 = { 8, 2, 3, 4, 5, 6, 7 };
            // accedemos al primer elemento
            Console.WriteLine(numeros3[0]); // Salida: 8
            // modificar tercer elemento
            numeros3[2] = 100;
            Console.WriteLine(numeros3[2]);
            // longitud array
            Console.WriteLine(numeros3.Length);
            // obtener y cambiar valores
            Console.WriteLine(numeros3.GetValue(1));
            numeros3.SetValue(12, 2);
            Console.WriteLine(numeros3.GetValue(2));
            // recorrer array con for
            for (int i = 0; i < numeros3.Length; i++)
            {
                Console.WriteLine(numeros3[i]);
                Console.WriteLine("Elemento en indice "+i+": " + numeros3[i]);
            }
            
            // recorremos con foreach
            foreach (int numero in numeros3)
            {
                Console.WriteLine("Numero: " + numero);
            }
            // array multidimensional
            int[,] matriz = new int[2, 3];
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            Console.WriteLine(matriz[1, 0]);

            int[,] matriz2 = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 } };
            for (int i = 0;i < 2; i++)
            {
                for (int j = 0;j < 4; j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Arrays de arrays
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 5 };
            Console.WriteLine(jaggedArray[0][1]);
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+ " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
