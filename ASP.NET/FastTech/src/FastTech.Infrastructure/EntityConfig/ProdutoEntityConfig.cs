using FastTech.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastTech.Infrastructure.EntityConfig;

public class ProdutoEntityConfig : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("Produtos");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .IsRequired()
            .HasColumnType("varchar(200)")
            .IsUnicode(false);

        builder.Property(x => x.Descricao)
           .IsRequired()
           .HasColumnType("varchar(700)")
           .IsUnicode(false);

        builder.Property(x => x.Ativo)
           .IsRequired();

        builder.Property(x => x.Cadastro)
            .IsRequired();

        builder.Property(x => x.Tipo)
           .IsRequired();

        builder.Property(x => x.QuantidadeEstoque)
           .IsRequired();

    }
}
