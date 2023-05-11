using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mp.component.domain.Entities;

namespace mp.component.infra.data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Pessoa");
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Nome");

            builder.Property(x => x.Document)
                .HasColumnName("Documento");

            builder.Property(x => x.Phone)
                .HasColumnName("Celular");

            builder.HasMany(x => x.Purchases)
                .WithOne(p => p.Person)
                .HasForeignKey(c => c.IdPerson);
        }
    }
}
