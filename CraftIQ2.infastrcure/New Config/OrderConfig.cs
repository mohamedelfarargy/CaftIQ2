using CraftI_2.Core.Entinty;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CraftIQ2.infastrcure.New_Config
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();
            builder.HasMany(o => o.OrderDetails)
              .WithOne(od => od.Order)
              .HasForeignKey(od => od.OrderId)
              .OnDelete(DeleteBehavior.NoAction); // تعطيل Casca
        }
    }
}
