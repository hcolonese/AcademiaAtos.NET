using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    class Operador : Funcionario
    {
        public Operador() { }
        public Operador(string nome, string depto, string dataCriacao, string rg, double salario, bool ativo) : base(nome, depto, dataCriacao, rg, salario, ativo) { }

        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Desempenha a função de Operador.");
        }
    }
}
