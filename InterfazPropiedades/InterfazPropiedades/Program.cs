using InterfazPropiedades.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazPropiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehiculo coche = new Coche { Velocidad = 100 };
            IVehiculo bicicleta = new Bicicleta { Velocidad = 20};
            coche.Arrancar();
            bicicleta.Arrancar();
        }
    }
}
