using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    public class Peixe
    {
        private string _nome;
        private int _nadadeiras;
        public Peixe(string nome, int nadadeiras)
        {
            _nome = nome;
            _nadadeiras = nadadeiras;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int Nadadeiras { get => _nadadeiras; set => _nadadeiras = value; }
    }
}
