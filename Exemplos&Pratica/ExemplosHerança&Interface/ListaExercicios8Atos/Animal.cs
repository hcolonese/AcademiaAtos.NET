using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    abstract class Animal
    {
        protected string nome;
        protected string sexo;
        protected string raca;
        public Animal(string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }
        public abstract void EmitirSom();
        public abstract void Dormir();
        public abstract void Caminhar();

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + nome + " Sexo " + sexo + " Raça: " + raca);
        }
    }
}
