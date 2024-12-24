using Microsoft.AspNetCore.Mvc;

namespace CraftIQ2.Api.Endpoints.Categories.read.byid
{
    public class ReadbyIdRequest
    {
        [FromRoute]
        public Guid categoryId { get; set; }
    }
}
