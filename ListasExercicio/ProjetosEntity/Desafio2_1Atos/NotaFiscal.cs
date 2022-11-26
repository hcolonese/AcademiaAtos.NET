using System;
using System.Collections.Generic;

namespace Desafio2_1Atos;

public partial class NotaFiscal
{
    public int IdNota { get; set; }

    public DateTime DataEmissao { get; set; }

    public int IdProduto { get; set; }

    public int IdCliente { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Produto IdProdutoNavigation { get; set; } = null!;
}
