﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    class PlayStation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando PS4");
            Ligado = true;
        }
    }
}
