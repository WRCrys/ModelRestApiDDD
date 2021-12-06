using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Infrastructure.Data.Mappings
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(c => c.LastName)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.ToTable("Client");


        }
    }
}
