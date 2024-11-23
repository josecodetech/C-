using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazHerencia.Properties
{
    internal interface IDispositivo1 : IEncendible
    {
        string Marca {  get; set; }
        void Reiniciar();
    }
}
