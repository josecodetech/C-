using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Laura");
           // gerente.Nombre = "Laura";
            gerente.Edad = 45;
            gerente.Departamento = "Recursos humanos";
           // gerente.Identificacion = "2323dac";
            gerente.MostrarIdentificacion();
            gerente.Saludar();
            gerente.MostrarDepartamento();
            Desarrollador desarrollador = new Desarrollador("Carlos");
            //desarrollador.Nombre = "Carlos";
            desarrollador.Edad = 30;
            desarrollador.LenguajePreferido = "Python";
            desarrollador.Saludar();
            desarrollador.MostrarLenguaje();
        }

    }
    class Empleado  
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        private string Identificacion { get; set; }
        public Empleado(string nombre)
        {
            Nombre = nombre;
            Console.WriteLine("Constructor de Empleado invocado");
        }
        public void MostrarIdentificacion()
        {
            Identificacion = "jkjdkf";
            Console.WriteLine($"Identificacion: {Identificacion}");
        }
        public virtual void Saludar() {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años");
        }
    }
    class Gerente : Empleado
    {
        public Gerente(string nombre) : base(nombre)
        {

        }

        public string Departamento { get; set; }
        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre} y soy gerente");
        }
        public void MostrarDepartamento()
        {
            Console.WriteLine($"{Nombre} es el gerente del departamento {Departamento}.");
        }
    }
    class Desarrollador : Empleado { 
        public string LenguajePreferido { get; set; }
        public Desarrollador(string nombre) : base(nombre) {
            Console.WriteLine("Constructor de Desarrollador invocado");
        }
        public void MostrarLenguaje()
        {
            Console.WriteLine($"{Nombre} prefiere programar en {LenguajePreferido}.");
        }
    }
}
