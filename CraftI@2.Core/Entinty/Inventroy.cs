namespace CraftI_2.Core.Entinty
{
    public class Inventroy : BaseEntity
    {
        public Inventroy() { }// for entity framework

        public string Name { get; set; } = string.Empty;
        public Guid _InventoryId { get; set; }
        public int Quantity { get; set; }
        public int Reorderlevel { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTimeOffset LastUpdated { get; set; }
    }
}
