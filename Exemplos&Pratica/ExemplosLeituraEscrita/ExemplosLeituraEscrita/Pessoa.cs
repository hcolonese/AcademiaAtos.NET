using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosLeituraEscrita
{
    public class Pessoa
    {
        private string _nome, _sexo = "", _email = "", _telefone = "", _estadoCivil = "";
        private int _idade, _casa;
        private float _aluguel;

        public Pessoa() { }

        public Pessoa(string nome, string sexo, string email, string telefone, string estadoCivil, int casaPropria, int idade, float aluguel)
        {
            this._nome = nome;
            this._sexo = sexo;
            this._email = email;
            this._telefone = telefone;
            this._estadoCivil = estadoCivil;
            this._casa = casaPropria;
            this._idade = idade;
            this._aluguel = aluguel;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }
        public int Idade { get => _idade; set => _idade = value; }
        public float Aluguel { get => _aluguel; set => _aluguel = value; }
        public int Casa { get => _casa; set => _casa = value; }

        public string RetornaDados()
        {
            string output = "";
            output = _nome + ";" + _idade + ";" + _sexo + ";" + _email + ";" + _telefone +";" + _estadoCivil + ";" + (_casa==1?"Sim":"Não") + ";" + _aluguel;
            return output;
        }
    }
}
