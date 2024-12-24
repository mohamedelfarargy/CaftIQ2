using CraftI_2.Core.Entinty;
using CraftI_2.Core.Entinty.Categories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CraftIQ2.infastrcure.Dbcontext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Inventroy> Inventroys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDeatils> OrderDeatils { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TransActions> TransActions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
