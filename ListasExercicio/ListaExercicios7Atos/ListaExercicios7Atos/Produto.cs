using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Produto
    {
        private string nome;
        private float preco;
        private int quantidade;

        public Produto(string nome, float preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade  = quantidade;
        }

        public float Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
