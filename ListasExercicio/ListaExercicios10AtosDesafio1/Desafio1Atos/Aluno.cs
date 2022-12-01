using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Atos
{
    public class Aluno : Pessoa
    {
        private string _matricula, _codigoCurso, _nomeCurso;
        public Aluno() { }
        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string matricula, string codCurso, string nomeCurso) : base(nome, telefone, cidade, rg, cpf) 
        {
            this._matricula = matricula;
            this._codigoCurso = codCurso;
            this._nomeCurso = nomeCurso;
        }

        public string Matricula { get => _matricula; set => _matricula = value; }
        public string CodigoCurso { get => _codigoCurso; set => _codigoCurso = value; }
        public string NomeCurso { get => _nomeCurso; set => _nomeCurso = value; }
    }
}
