using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios8Atos
{
    public class ItemCenario
    {
        private string _descricao;
        private DateTime _dataCriacao;
        private float _altura;

        public ItemCenario(string descricao, DateTime dataCriacao, float altura)
        {
            this._descricao = descricao;
            this._dataCriacao = dataCriacao;
            this._altura = altura;
        }

        public string Descricao { get => _descricao; set => _descricao = value; }
        public DateTime DataCriacao { get => _dataCriacao; set => _dataCriacao = value; }
        public float Altura { get => _altura; set => _altura = value; }

        public void ImprimirDados()
        {
            Console.WriteLine("Descrição: "+ _descricao);
            DateTime data = _dataCriacao;
            Console.WriteLine("Data de criação: " + data.ToString("d"));
            Console.WriteLine("Altura: "+ _altura);
        }
        public void TempoCriacao()
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine("Esse item foi criado a " + (thisDay.Subtract(_dataCriacao)).TotalDays + " dias atrás");
        }
    }
}
