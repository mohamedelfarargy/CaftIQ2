using huzcodes.Persistence.Implementations.EfRepository;


namespace CraftIQ2.infastrcure.Dbcontext
{
    public class InventroyReposatry<TEntity> :HuzcodesRepository<TEntity> where TEntity: class
    {
        public InventroyReposatry(AppDbContext dbContext):base(dbContext)
        {
            
        }
    }
}
