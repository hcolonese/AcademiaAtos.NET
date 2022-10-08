using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Lampada
    {
        //Classe criada de exemplo nas aulas
        private bool ligada;
        private double potencia;

        public void ligar()
        {
            ligada = true;
            Console.WriteLine("Ligando Lâmpada");
        }
        public void desligar()
        {
            ligada = false;
            Console.WriteLine("Desligando Lâmpada");
        }
        public bool estaLigada()
        {
            if (ligada)
            {
                Console.WriteLine("Está ligada");
            }
            else
                Console.WriteLine("Está desligada");
            return ligada;
        }
    }
}
