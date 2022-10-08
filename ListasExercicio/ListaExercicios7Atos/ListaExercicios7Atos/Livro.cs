using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    internal class Livro
    {
        private string nome;
        private string categoria;
        private string dataLancamento;

        public Livro(string nome, string categoria, string dataLancamento)
        {
            this.nome = nome;
            this.categoria = categoria;
            this.dataLancamento = dataLancamento;
        }
        public string GetNome() {
            return this.nome;
        }
        public string GetCategoria()
        {
            return this.categoria;
        }
        public string GetDataLancamento()
        {
            return this.dataLancamento;
        }
    }
}
