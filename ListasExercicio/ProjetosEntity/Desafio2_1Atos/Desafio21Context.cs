using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Desafio2_1Atos;

public partial class Desafio21Context : DbContext
{
    public Desafio21Context()
    {
    }

    public Desafio21Context(DbContextOptions<Desafio21Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Fornecedor> Fornecedors { get; set; }

    public virtual DbSet<NotaFiscal> NotaFiscals { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=desafio_2_1;User ID=AtosEntity2;password=Atos_Entity_2;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__885457EEC788C3AE");

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.Cidade)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cidade");
            entity.Property(e => e.Cpf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cpf");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Fornecedor>(entity =>
        {
            entity.HasKey(e => e.IdFornecedor).HasName("PK__Forneced__CBE1227C6254E849");

            entity.ToTable("Fornecedor");

            entity.Property(e => e.IdFornecedor).HasColumnName("idFornecedor");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<NotaFiscal>(entity =>
        {
            entity.HasKey(e => e.IdNota).HasName("PK__NotaFisc__AD5F462EB882B3FE");

            entity.ToTable("NotaFiscal");

            entity.Property(e => e.IdNota).HasColumnName("idNota");
            entity.Property(e => e.DataEmissao)
                .HasColumnType("date")
                .HasColumnName("dataEmissao");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdProduto).HasColumnName("idProduto");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.NotaFiscals)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("fk_Cliente_Nota");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.NotaFiscals)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("fk_Produto_Nota");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.IdProduto).HasName("PK__Produto__5EEDF7C3C502B0EB");

            entity.ToTable("Produto");

            entity.Property(e => e.IdProduto).HasColumnName("idProduto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdFornecedor).HasColumnName("idFornecedor");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Preco).HasColumnName("preco");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");

            entity.HasOne(d => d.IdFornecedorNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.IdFornecedor)
                .HasConstraintName("fk_Fornecedor_Produto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
