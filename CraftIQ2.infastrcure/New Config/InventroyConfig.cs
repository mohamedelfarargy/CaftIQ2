using CraftI_2.Core.Entinty;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CraftIQ2.infastrcure.New_Config
{
    public class InventroyConfig : IEntityTypeConfiguration<Inventroy>
    {
        public void Configure(EntityTypeBuilder<Inventroy> builder)
        {
            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Location)
                   .HasMaxLength(200);

            builder.Property(p => p.Name)
                   .HasMaxLength(50);
        }
    }
}
