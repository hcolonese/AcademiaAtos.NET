using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    public class Gato
    {
        private string _nome, _cor;

        public Gato(string nome, string cor)
        {
            this._nome = nome;
            this._cor = cor;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Cor { get => _cor; set => _cor = value; }
    }
}
