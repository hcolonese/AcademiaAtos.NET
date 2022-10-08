using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Cliente
    {
        private string  nome;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public Cliente (string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

    }
}
