using System.ComponentModel.DataAnnotations;

namespace CraftIQ2.Api.Endpoints.Categories.create
{
    public class CreateCategoriesRequset
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
