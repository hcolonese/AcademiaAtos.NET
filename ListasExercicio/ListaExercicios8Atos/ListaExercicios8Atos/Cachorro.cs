using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    public class Cachorro
    {
        private string _nome, _raca;

        public Cachorro(string nome, string raca)
        {
            _nome = nome;
            _raca = raca;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Raca { get => _raca; set => _raca = value; }
    }
}
