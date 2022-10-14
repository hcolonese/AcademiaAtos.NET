using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    class Gato : Animal
    {
        public Gato(string nome, string sexo, string raca) : base(nome, sexo, raca) { }
        public override void EmitirSom()
        {
            Console.WriteLine("Miado");
        }
        public override void Dormir()
        {
            Console.WriteLine("Gato Dormindo");
        }
        public override void Caminhar()
        {
            Console.WriteLine("Gato Caminhando");
        }
    }
}
