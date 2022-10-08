using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Aluguel
    {
        private string dataInicio;
        private int dias;
        private float custo;
        private Carro carro;
        private Cliente cliente;

        public Aluguel() { }
        public Aluguel(string dataInicio, int dias, float custo, Carro carro, Cliente cliente)
        {
            this.dataInicio = dataInicio;
            this.dias = dias;
            this.custo = custo;
            this.carro = carro;
            this.cliente = cliente;
        }

        public string DataInicio { get => dataInicio; set => dataInicio = value; }
        public int Dias { get => dias; set => dias = value; }
        public float Custo { get => custo; set => custo = value; }
        public Carro Carro { get => carro; set => carro = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public void MostrarDadosAluguel()
        {
            Console.WriteLine("Cliente: "+cliente.Nome);
            Console.WriteLine("Carro marca: "+carro.Marca+" Placa: "+carro.Placa+" Kilometragem: "+carro.Kilometragem);
            Console.WriteLine("Data de início: "+dataInicio);
            Console.WriteLine("Quantidade de dias: "+dias);
            Console.WriteLine("Custo: "+custo);

        }
    }
}
