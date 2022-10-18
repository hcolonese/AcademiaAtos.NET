using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    public class DicionarioLivro
    {
        private SortedDictionary<string, int> dicionarioLivros = new SortedDictionary<string, int>();

        public void Adicionar(string nome, int quantPaginas)
        {
            dicionarioLivros.Add(nome, quantPaginas);
        }
        public void ConsultaTodosLivros()
        {
            foreach (KeyValuePair<string, int> livro in dicionarioLivros)
            {
                Console.WriteLine("Livro: "+livro.Key + " com " + livro.Value+ " paginas");
            }
        }
        public void PesquisaLivro(string nome)
        {
            if (dicionarioLivros.ContainsKey(nome))
            {
                Console.WriteLine("Livro encontrado!");
            }
            else
            {
                Console.WriteLine("Livro não existe");
            }
        }
        public void RemoverLivro(string nome)
        {
            if (dicionarioLivros.ContainsKey(nome))
            {
                dicionarioLivros.Remove(nome);
                Console.WriteLine("Livro "+nome +" removido!");
            }
            else
                Console.WriteLine("Livro não encontrado.");
        }
        public SortedDictionary<string, int> DicionarioLivros { get => dicionarioLivros; set => dicionarioLivros = value; }
    }
}
