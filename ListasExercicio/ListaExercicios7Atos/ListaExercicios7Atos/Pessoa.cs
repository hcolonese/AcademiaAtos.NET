using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    internal class Pessoa
    {
        private string nome;
        private string sexo;
        private int idade;
        private float peso;

        public Pessoa(string nome, string sexo, int idade, float peso)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
            this.peso = peso;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public string GetSexo()
        {
            return this.sexo;
        }
        public int GetIdade()
        {
            return this.idade;
        }
        public float GetPeso()
        {
            return this.peso;
        }
    }
}
