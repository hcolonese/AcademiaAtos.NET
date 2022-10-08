using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Carro
    {
        private float kilometragem;
        private string cor, marca, ano, placa;


        public Carro() { }
        public Carro(string placa, string cor, string marca, float kilometragem)
        {
            this.placa = placa;
            this.cor = cor;
            this.marca = marca;
            this.kilometragem = kilometragem;
        }

        public float Kilometragem { get => kilometragem; set => kilometragem = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
    }
}
