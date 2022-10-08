using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Pessoa
    {
        private string nome,sexo;
        private int idade;
        private float peso;

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

        public string GetStringSexo()
        {
            if (sexo == "F")
            {
                return "Feminino";
            }
            else
                return "Masculino";
        }
    }
}
