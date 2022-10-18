using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    abstract class Eletronico
    {
        private int _volts, _potencia;
        private bool _ligado;

        public bool Ligado { get => _ligado; set => _ligado = value; }

        public abstract void Ligar();
        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando.");
        }

    }
}
