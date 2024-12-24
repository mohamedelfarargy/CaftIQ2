using CraftI_2.Core.Entinty.Categories;

namespace CraftI_2.Core.Entinty
{
    public class Product : BaseEntity
    {
        public Guid _ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public float Weight { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public decimal TaxCost { get; set; }
        public decimal ProfitPerUnit { get; set; }
        public decimal ProductionCost { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new();
        public List<OrderDeatils> OrderDetails { get; set; } = new();
    }
}
