using CraftI_2.Core.Entinty;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CraftIQ2.infastrcure.New_Config
{
    public class OrderDeatilsConfig : IEntityTypeConfiguration<OrderDeatils>
    {
        public void Configure(EntityTypeBuilder<OrderDeatils> builder)
        {
            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.HasOne(od => od.Product)
              .WithMany(p => p.OrderDetails)
              .HasForeignKey(od => od.ProductId)
              .OnDelete(DeleteBehavior.NoAction);

            // تعطيل Cascade Delete في العلاقة مع Order
            builder.HasOne(od => od.Order)
                   .WithMany(o => o.OrderDetails)
                   .HasForeignKey(od => od.OrderId)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
