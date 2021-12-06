using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Infrastructure.Data.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(p => p.Value)
                .IsRequired()
                .HasColumnType("numeric(12,4)");

            builder.ToTable("Product");
        }
    }
}
