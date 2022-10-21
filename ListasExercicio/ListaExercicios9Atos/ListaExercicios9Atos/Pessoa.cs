using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios9Atos
{
    public class Pessoa
    {
        private string _nome, _email;
        public Pessoa(string nome, string email)
        {
            this._nome = nome;
            this._email = email;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
