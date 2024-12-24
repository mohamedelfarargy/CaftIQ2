using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CraftIQ2.Api.Endpoints.Categories.update
{
    public class UpdateRequest
    {
        [FromRoute]
        public  Guid CategoryId { get; set; }
        [FromBody]
        public body Categorybody { get; set; }
    }
    public class body
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
