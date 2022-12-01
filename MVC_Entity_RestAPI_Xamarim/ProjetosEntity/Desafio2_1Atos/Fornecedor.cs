using System;
using System.Collections.Generic;

namespace Desafio2_1Atos;

public partial class Fornecedor
{
    public int IdFornecedor { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Endereco { get; set; } = null!;

    public virtual ICollection<Produto> Produtos { get; } = new List<Produto>();
}
