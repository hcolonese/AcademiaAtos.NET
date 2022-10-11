using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Agenda
    {
        List<Pessoa> pessoas;
        public Agenda()
        {
            pessoas = new List<Pessoa>();
            
        }
        public void ArmazenaPessoa(string nome, string sexo, int idade, float peso)
        {
            Pessoa p = new Pessoa(nome, sexo, idade, peso);
            pessoas.Add(p);
        }
        public void ImprimeAgenda()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Pessoas:");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Nome: "+pessoa.Nome);
                Console.WriteLine("Sexo: " + pessoa.Sexo);
                Console.WriteLine("Idade: " + pessoa.Idade);
                Console.WriteLine("Peso: " + pessoa.Peso);
                Console.WriteLine("-----------");
            }
        }       
        public Pessoa BuscaPessoa(string nome)
        {
            foreach (var pessoa in pessoas)
            {
                if(pessoa.Nome.Equals(nome))
                {
                    return pessoa;
                }
            }
            return null;
        }
        public void Encontrada(Pessoa p)
        {
            if (p != null)
            {
                Console.WriteLine("Pessoa encontrada");
            }
            else
                Console.WriteLine("Pessoa não existe");
        }
        public void RemovePessoa(string nome)
        {
            Pessoa p= BuscaPessoa(nome);
            if (p != null)
            {
                pessoas.Remove(p);
                Console.WriteLine("Pessoa removida com sucesso!");
            }
            else
                Console.WriteLine("Pessoa não encontrada!");


        }
    }
}
