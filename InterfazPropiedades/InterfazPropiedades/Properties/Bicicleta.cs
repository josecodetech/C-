using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazPropiedades.Properties
{
    internal class Bicicleta : IVehiculo
    {
        public int Velocidad { get; set; }

        public void Arrancar()
        {
            Console.WriteLine($"La bicicleta arranca a una velocidad de {Velocidad}.");
        }
    }
}
