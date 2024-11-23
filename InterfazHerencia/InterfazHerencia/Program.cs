using InterfazHerencia.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IDispositivo1 tablet = new IDispositivo1(); // no se puede instanciar de una interfaz

            IDispositivo1 televisor = new Televisor { Marca = "Samsung" };
            televisor.Encender();
            televisor.Reiniciar();
            televisor.Apagar();
        }
    }
}
