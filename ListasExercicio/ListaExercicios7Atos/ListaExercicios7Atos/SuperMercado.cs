using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class SuperMercado
    {
        private List<Produto> produtos = new List<Produto>();
        private List<Pedido> pedidos = new List<Pedido>();

        public SuperMercado(List<Produto> lista)
        {
            this.produtos = lista;
        }
        public List<Produto> Produtos { get => produtos; set => produtos = value; }
        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }

        public void AdicionarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        public void RetornaProdutosMercado()
        {
            Console.WriteLine("Lista de produtos no mercado:");
            foreach (Produto produto in produtos)
                Console.WriteLine("Produto: " + produto.Nome + " com " + produto.Quantidade + " unidades.");
        }

        public void RetornaPedidosMercado()
        {
            foreach (var pedido in pedidos)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Pedido:");
                foreach (var item in pedido.Items)
                {
                    Console.WriteLine("Nome do produto: " + item.Produto.Nome);
                    Console.WriteLine("Quantidade do produto: " + item.Quantidade);
                }
                Console.WriteLine("-----------");
            }
        }

        public bool VerificaProduto(string nomeProd)
        {
            foreach (var produto in produtos)
            {
                if (produto.Nome == nomeProd)
                {
                    Console.WriteLine("Possui esse produto");
                    return true;
                }
            }
            Console.WriteLine("Não possui esse produto");
            return false;
        }

    }
}
