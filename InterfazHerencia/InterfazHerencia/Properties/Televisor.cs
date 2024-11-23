using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazHerencia.Properties
{
    internal class Televisor : IDispositivo1
    {
        public string Marca { get; set; }

        public void Apagar()
        {
            Console.WriteLine($"El televisor {Marca} esta apagado");
        }

        public void Encender()
        {
            Console.WriteLine($"El televisor {Marca} esta encendido");
        }

        public void Reiniciar()
        {
            Console.WriteLine($"El televisor {Marca} se esta reiniciando");
        }
    }
}
