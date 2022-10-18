using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    class Celular : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando celular");
            Ligado = true;
        }
    }
}
