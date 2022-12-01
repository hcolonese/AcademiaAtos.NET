﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Atos
{
    public class Pessoa
    {
        private string _nome,_telefone, _cidade, _rg, _cpf;
        
        public Pessoa() { }
        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            this._nome = nome;
            this._telefone = telefone;
            this._cidade = cidade;
            this._rg = rg;
            this._cpf = cpf;

        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
    }
}
