using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class ContaBancaria
    {
        //Classe criada de exemplo nas aulas
        private Cliente cliente;
        private string agencia, tipo, conta;
        private float saldo=0;

        public Cliente Cliente { get => cliente; set => cliente = value; }

        public ContaBancaria(string agencia, string tipo, string conta, Cliente cliente, float saldo)
        {
            this.agencia = agencia;
            this.tipo = tipo;
            this.conta = conta;
            this.cliente = cliente;
            this.saldo = saldo;
        }
        public void Sacar(float valor)
        {
            saldo -= valor;
            Console.WriteLine("Foram sacados: " + valor + " reais.");
        }
        public void Depositar(float valor)
        {
            saldo += valor;
            Console.WriteLine("Foram depositados: "+valor+" reais.");
        }
        public float ConsultarSaldo()
        {
            return saldo;
        }
        public void ExibirDados()
        {
            Console.WriteLine("Cliente é:" + cliente);
            Console.WriteLine("Número da Agência é:"+agencia);
            Console.WriteLine("Número da Conta é:" + conta);
            Console.WriteLine("Tipo da transação é:" + tipo);
            Console.WriteLine("Saldo da Conta é:" + saldo);
        }
    }
}
