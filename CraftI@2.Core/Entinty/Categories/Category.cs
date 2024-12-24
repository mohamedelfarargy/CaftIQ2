namespace CraftI_2.Core.Entinty.Categories
{
    public class Category : BaseEntity
    {
        public Guid _CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // relation with products
        public List<Product> Products { get; set; } = new();
        public Category()
        {

        }
        public Category(string name, string description)
        {
            _CategoryId = Guid.NewGuid();
            Name = name;
            Description = description;
            CreatedBy = Guid.Empty;
            CreatedOn = DateTimeOffset.Now;
            ModifiedBy = Guid.Empty;
            ModifiedOn = DateTimeOffset.Now;
        }
        public void updateCategory(string name, string description, Guid modifiedby)
        {
            Name = name;
            Description = description;
            ModifiedBy = modifiedby;
            ModifiedOn = DateTimeOffset.Now;
        }
    }
}
