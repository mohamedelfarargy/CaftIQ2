using CraftIQ2.infastrcure.Dbcontext;
using huzcodes.Persistence.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CraftIQ2.infastrcure
{
    public static class InfrastructureRegistrations
    {
        public static void AddInventoryDbContext(this IServiceCollection services, string connectionString) =>
          services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString));

        public static void AddInfrastructureRegistrations(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(InventroyReposatry<>));
            services.AddScoped(typeof(IReadRepository<>), typeof(InventroyReposatry<>));
        }

    }
}
