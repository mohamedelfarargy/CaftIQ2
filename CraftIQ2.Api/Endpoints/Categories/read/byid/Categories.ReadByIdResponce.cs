using CraftIQ2.Shared.Contracts.Categories;

namespace CraftIQ2.Api.Endpoints.Categories.read.byid
{
    public class ReadByIdResponce
    {
         public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }

        public ReadByIdResponce(CategoriesContract contract)
        {
            CategoryId = contract.CategoryId;
            Name = contract.Name;
            Description = contract.Description;
            CreatedBy = contract.CreatedBy;
            CreatedOn = contract.CreatedOn;
            ModifiedBy = contract.ModifiedBy;
            ModifiedOn = contract.ModifiedOn;
        }
    }
}
