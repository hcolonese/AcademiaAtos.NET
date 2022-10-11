using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Item
    {
        private Produto produto;
        private int quantidade;
        public Item(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
        }

        public Produto Produto { get => produto; set => produto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
