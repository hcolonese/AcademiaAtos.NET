using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios9Atos
{
    public class Email
    {
        private string _nome, _dominio;
        public Email(string email, string dominio)
        {
            this._nome = email;
            this._dominio = dominio;
        }
        public string Nome { get => _nome; set => _nome = value; }
        public string Dominio { get => _dominio; set => _dominio = value; }
    }
}
