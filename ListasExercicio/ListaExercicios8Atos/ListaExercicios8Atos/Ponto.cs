using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    public class Ponto
    {
        private float _x, _y;

        public Ponto(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public void ExibirCoordenadas()
        {
            Console.WriteLine("X: "+ _x + " Y: "+ _y);
        }
        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
    }
}
