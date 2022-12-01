using System;
using System.Collections.Generic;

namespace Desafio2_1Atos;

public partial class Produto
{
    public int IdProduto { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public double Preco { get; set; }

    public int Quantidade { get; set; }

    public int IdFornecedor { get; set; }

    public virtual Fornecedor IdFornecedorNavigation { get; set; } = null!;

    public virtual ICollection<NotaFiscal> NotaFiscals { get; } = new List<NotaFiscal>();
}
