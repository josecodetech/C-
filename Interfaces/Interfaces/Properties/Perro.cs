using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Properties
{
    internal class Perro : IAnimal
    {
        public void EmitirSonido()
        {
            Console.WriteLine("El pero dice: Guau");
        }
    }
}
