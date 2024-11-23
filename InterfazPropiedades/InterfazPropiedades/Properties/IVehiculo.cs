using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazPropiedades.Properties
{
    internal interface IVehiculo
    {
        int Velocidad {  get; set; }
        void Arrancar();
    }
}
