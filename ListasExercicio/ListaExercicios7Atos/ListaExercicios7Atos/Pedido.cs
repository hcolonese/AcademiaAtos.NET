using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Pedido
    {
        private List<Item> items;
        private string pagamento;
        public List<Item> Items { get => items; set => items = value; }

        public Pedido()
        {
            items = new List<Item>();
        }

        public void Adicionar(Item item)
        {
            items.Add(item);
        }
    }
}
