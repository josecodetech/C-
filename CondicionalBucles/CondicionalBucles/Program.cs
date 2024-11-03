using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalBucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicional IF
            int edad = 16;
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else if (edad > 14)
            {
                Console.WriteLine("Eres menor de edad.");
            }
            else
            {
                Console.WriteLine("Eres un niño.");
            }
            // Condicional Switch
            int dia = 3;
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                default:
                    Console.WriteLine("Dia no valido");
                    break;
            }
            Console.WriteLine("Fin del condicional Switch");
            // Bucles
            // Bucle FOR
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Iteracion: " + i);
            }
            // Bucle While
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine("Contador: " + contador);
                contador++;
            }
            // Bucle do-while
            contador = 6;
            do
            {
                Console.WriteLine("Contador: " + contador);
                contador++;

            } while (contador <= 5);
            // Ejercicios
            // Positivo o negativo
            int numero = 0;
            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo.");
            } else if (numero < 0)
            {
                Console.WriteLine("El numero es negativo.");
            }
            else
            {
                Console.WriteLine("El numero es cero.");
            }
            // Tabla de multiplicar
            Console.WriteLine("Tabla de multiplicar del 5: ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("5 x " + i + " = " + (5 * i));
            }
            // Adivina numero
            Console.WriteLine("Adivina un numero entre 1 y 10: ");
            int numeroSecreto = 7;
            int numeroUsuario=0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Intento " + i + ": ");
                numeroUsuario = int.Parse(Console.ReadLine());
                if (numeroUsuario == numeroSecreto)
                {
                    Console.WriteLine("Felicidades, has acertado!!!");
                    break;
                }
                else if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("El numero es mayor.");
                }
                else
                {
                    Console.WriteLine("El numero es menor.");
                }
                if (i == 3)
                {
                    Console.WriteLine("Lo siento no has podido adivinarlo.");
                }
            }
        }
    }
}
