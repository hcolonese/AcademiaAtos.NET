using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    public class Personagem
    {
        private string _nome;
        private int _poder;

        public Personagem() { }
        public Personagem(string nome, int poder)
        {
            this._nome = nome;
            this._poder = poder;
        }
        public void ExibirDados()
        {
            Console.WriteLine("Nome do personagem: "+_nome);
            Console.WriteLine("Poder do personagem: "+_poder);
        }
        public string Nome { get => _nome; set => _nome = value; }
        public int Poder { get => _poder; set => _poder = value; }
    }
}
