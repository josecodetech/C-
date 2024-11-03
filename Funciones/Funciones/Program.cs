using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funciones
            // tipoDeRetorno NombreFuncion(parametros) {
            // Codigo funcion
            // return valor; si es void no devuelve valor 
            // }
            // MostrarMensaje();
            Saludar("Jose");
            int numero = ObtenerNumeroAleatorio();
            Console.WriteLine("Numero aleatorio = " + numero);
            int a = 4;
            int b = 5;
            int resultado = Sumar(a,b);
            Console.WriteLine($"Resultado de sumar {a} y {b} es igual a {resultado}");
            double c = 6.3;
            double d = 5.4;
            double resultado2 = Sumar(c,d);
            Console.WriteLine($"Resultado de sumar {c} y {d} es igual a {resultado2}");
            numero = 5;
            Duplicar(numero);
            Console.WriteLine("El numero fuera de la funcion es igual a " + numero);
            numero = 8;
            Duplicar2(ref numero);
            Console.WriteLine("El numero fuera de la funcion es igual a " + numero);
            int miEdad;
            string miNombre;
            Obtenerdatos(out miEdad, out miNombre);
            Console.WriteLine($"Nombre: {miNombre}, Edad: {miEdad}");
        }
        static void MostrarMensaje()
        {
            Console.WriteLine("Hola, este es un mensaje de ejemplo.");
        }
        static void Saludar(string nombre)
        {
            Console.WriteLine("Hola, " + nombre);
        }
        static int ObtenerNumeroAleatorio()
        {
            int numero = new Random().Next(1, 100);
            return numero;
        }
        static int Sumar(int a, int b) { 
            return a + b;
        }
        static double Sumar(double a, double b) { 
            return a + b; 
        }
        static void Duplicar(int numero)
        {
            numero = numero * 2;
            Console.WriteLine("La variable numero en esta funcion vale : " + numero);
        }
        static void Duplicar2(ref int numero) {
            numero = numero * 2;
            Console.WriteLine("La variable numero en esta funcion vale : " + numero);
        }
        static void Obtenerdatos(out int edad, out string nombre)
        {
            edad = 30;
            nombre = "Jose";
        }
    }
}
