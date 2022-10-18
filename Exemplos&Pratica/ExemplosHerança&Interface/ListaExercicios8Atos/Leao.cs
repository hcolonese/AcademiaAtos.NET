using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    class Leao : Animal
    {
        public Leao(string nome, string sexo, string raca) : base(nome, sexo, raca) { }

        public override void EmitirSom()
        {
            Console.WriteLine("Rugido");
        }
        public override void Dormir()
        {
            Console.WriteLine("Leão Dormindo");
        }
        public override void Caminhar()
        {
            Console.WriteLine("Leão Caminhando");
        }
    }
}
