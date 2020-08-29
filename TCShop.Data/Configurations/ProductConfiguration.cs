using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCShop.Data.Entities;

namespace TCShop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired().HasColumnType($"decimal(10,2)");
            builder.Property(x => x.OriginalPrice).IsRequired().HasColumnType($"decimal(10,2)");
            builder.Property(x => x.DateCreated).HasColumnType($"datetime");
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
        }
    }
}