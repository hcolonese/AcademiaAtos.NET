using System;
using System.Collections.Generic;

namespace Desafio2_1Atos;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public virtual ICollection<NotaFiscal> NotaFiscals { get; } = new List<NotaFiscal>();
}
