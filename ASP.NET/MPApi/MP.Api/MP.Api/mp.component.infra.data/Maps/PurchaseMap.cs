using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mp.component.domain.Entities;

namespace mp.component.infra.data.Maps
{
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {

            builder.ToTable("Compra");
            builder.HasKey(p => p.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.IdPerson)
                .HasColumnName("IdPessoa");

            builder.Property(x => x.IdProduct)
                .HasColumnName("IdProduto");

            builder.Property(x => x.Date)
                .HasColumnName("DataCompra");

            builder.HasOne(x => x.Person)
                .WithMany(x => x.Purchases);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Purchases);
        }
    }
}
