using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crear objeto
            Coche miCoche = new Coche("Toyota","Corolla",2021);
            Coche tuCoche = new Coche("Seat", "Arona", 2022);
            // asignar valores 
            // miCoche.Marca = "Toyota";
            // miCoche.Modelo = "Corolla";
            //miCoche.Año = 2021;
            miCoche.Velocidad = 100;
            tuCoche.Velocidad = 140;
            // miCoche.Velocidad = -25;
            // llamada a metodo
            miCoche.Conducir();
            // mostramos informacion
            Console.WriteLine($"Coche: {miCoche.Marca}");
            // llamada a metodo
            // tuCoche.Conducir(120);
            tuCoche.Conducir(tuCoche.Velocidad);
            // mostramos informacion
            Console.WriteLine($"Coche: {tuCoche.Marca}");
        }

    }
    public class Coche
    {
        // propiedades 
        public string Marca { get; set; }
        public string Modelo { get; set; }        //  private protected
        public int Año { get; set; }
        private int _velocidad;
        // encapsulacion
        public int Velocidad {
            get { return _velocidad; }
            set { if (value >= 0) _velocidad = value;
                else Console.WriteLine("La velocidad no puede ser negativa.");
            }
        }
        // constructor
        public Coche(string marca, string modelo, int año) {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }
        // metodo
        public void Conducir()
        {
            Console.WriteLine("El coche esta en movimiento.");
        }
        public void Conducir(int velocidad)
        {
            Console.WriteLine($"El coche esta en movimiento a {velocidad} km/h.");
        }
    }
}
