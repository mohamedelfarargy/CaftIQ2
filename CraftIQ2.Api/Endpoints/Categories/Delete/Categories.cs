using CraftI_2.Core.interfaces;
using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ2.Api.Endpoints.Categories.Delete
{
    public class Categories(IcategoriesService services) : EndpointsAsync.WithRequest<CategoriesDeleteRequest>
                                                        .WithActionResult
    {
        private readonly IcategoriesService _services = services;
        [HttpDelete(Routes.CategoriesRoutes.Delete)]
        public override async Task<ActionResult> HandleAsync(CategoriesDeleteRequest request, CancellationToken cancellationToken = default)
        {
             await _services.DeleteCategory(request.categoryId);
            return Ok("your opject deleted");
        }
    }
}
