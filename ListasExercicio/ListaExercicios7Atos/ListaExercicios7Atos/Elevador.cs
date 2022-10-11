using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Elevador
    {
        private int andarAtual, totalAndares, capacidade, lotacaoAtual;
        public Elevador(int totalAndares, int capacidade)
        {
            this.andarAtual = 0;
            this.lotacaoAtual = 0;
            this.totalAndares = totalAndares;
            this.capacidade = capacidade;
        }

        public int AndarAtual { get => andarAtual; set => andarAtual = value; }
        public int TotalAndares { get => totalAndares; set => totalAndares = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        public int LotacaoAtual { get => lotacaoAtual; set => lotacaoAtual = value; }

        public void Entra()
        {
            if(lotacaoAtual+1 <= capacidade)
            {
                lotacaoAtual++;
                Console.WriteLine("Entrou 1 pessoa.");
            }
            else
                Console.WriteLine("Elevador lotado");
        }
        public void Sai()
        {
            if (lotacaoAtual>0)
            {
                lotacaoAtual--;
                Console.WriteLine("Saiu 1 pessoa.");
            }
            else
                Console.WriteLine("Não há pessoas no elevador.");
        }
        public void Sobe()
        {
            if (andarAtual + 1 <= totalAndares)
            {
                andarAtual++;
                Console.WriteLine("Subiu 1 andar.");
            }
            else
                Console.WriteLine("Elevador já está no último andar");
        }
        public void Desce()
        {
            if (andarAtual >=1)
            {
                andarAtual--;
                Console.WriteLine("Desceu 1 andar.");
            }
            else
                Console.WriteLine("Elevador já está no primeiro andar");
        }
    }   
}
