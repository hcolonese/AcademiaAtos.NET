using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Pessoa
    {
        Pessoa pai, mae;
        private string nome,sexo;
        private int idade;
        private float peso;

        public Pessoa() { }
        public Pessoa(string nome, string sexo, int idade, float peso)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
            this.peso = peso;
            Console.WriteLine("Pessoa criada com sucesso!");
        }

        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }
        public float Peso { get => peso; set => peso = value; }
        public Pessoa Pai { get => pai; set => pai = value; }
        public Pessoa Mae { get => mae; set => mae = value; }

        public string GetStringSexo()
        {
            if (sexo == "F")
            {
                return "Feminino";
            }
            else
                return "Masculino";
        }
        public Pessoa GetavoF()
        {
            return Mae.Mae;
        }
        public Pessoa GetavoM()
        {
            return Mae.Pai;
        }
        public void RetornaArvore()
        {
            Pessoa avoF = GetavoF();
            Pessoa avoM = GetavoM();
            Console.WriteLine("Sua árvore genealógica é :");
            Console.WriteLine("Sua avô é: "+ Mae.Pai.Nome+ " e seu avó é: "+ Mae.Mae.Nome);
            Console.WriteLine("Sua mãe é: " + Mae.Nome + " e seu pai é: " + Pai.Nome);
            Console.WriteLine("e você: "+Nome);
        }
    }
}
