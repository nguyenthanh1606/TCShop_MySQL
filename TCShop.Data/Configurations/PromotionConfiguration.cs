using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCShop.Data.Entities;

namespace TCShop.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseMySqlIdentityColumn();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.FromDate).HasColumnType($"datetime");
            builder.Property(x => x.ToDate).HasColumnType($"datetime");
            builder.Property(x => x.DiscountAmount).HasColumnType($"decimal(10,2)");
        }
    }
}