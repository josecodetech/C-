﻿using Interfaces.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal perro = new Perro();
            IAnimal gato = new Gato();
            perro.EmitirSonido();
            gato.EmitirSonido();
        }
    }

}
