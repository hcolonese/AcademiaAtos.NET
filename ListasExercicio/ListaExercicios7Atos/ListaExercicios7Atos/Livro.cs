using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Livro
    {
        private string nome;
        private string categoria;
        private string dataLancamento;

        public Livro(string nome, string categoria, string dataLancamento)
        {
            this.nome = nome;
            this.categoria = categoria;
            this.dataLancamento = dataLancamento;
            Console.WriteLine("Livro criado com sucesso!");
        }

        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string DataLancamento { get => dataLancamento; set => dataLancamento = value; }
    }
}
