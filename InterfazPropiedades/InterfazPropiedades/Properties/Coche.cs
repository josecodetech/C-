using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazPropiedades.Properties
{
    internal class Coche : IVehiculo
    {
        public int Velocidad { 
            get; set;
        }

        public void Arrancar()
        {
            Console.WriteLine($"El coche arranca a una velocidad de {Velocidad} km/h.");
        }
    }
}
