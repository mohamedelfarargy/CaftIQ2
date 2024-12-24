using Microsoft.AspNetCore.Mvc;

namespace CraftIQ2.Api.Endpoints.Categories.Delete
{
    public class CategoriesDeleteRequest
    {
        [FromRoute]
        public Guid categoryId { get; set; }
    }
}
