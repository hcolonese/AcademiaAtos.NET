using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios9Atos
{
    public class Figurinha
    {
        private string _codigo, _selecao, _nomeJogador;
        public Figurinha(string codigo, string selecao, string nomeJogador)
        {
            _codigo = codigo;
            _selecao = selecao;
            _nomeJogador = nomeJogador;
        }

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Selecao { get => _selecao; set => _selecao = value; }
        public string NomeJogador { get => _nomeJogador; set => _nomeJogador = value; }
    }
}
