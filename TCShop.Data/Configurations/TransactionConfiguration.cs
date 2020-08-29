using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCShop.Data.Entities;

namespace TCShop.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseMySqlIdentityColumn();
            builder.Property(x => x.TransactionDate).HasColumnType($"datetime");
            builder.Property(x => x.Amount).HasColumnType($"decimal(10,2)");
            builder.Property(x => x.Fee).HasColumnType($"decimal(10,2)");
            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.UserId);

        }
    }
}