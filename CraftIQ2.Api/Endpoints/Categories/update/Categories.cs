using CraftI_2.Core.interfaces;
using CraftIQ2.Shared.Contracts.Categories;
using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Core.Operations;

namespace CraftIQ2.Api.Endpoints.Categories.update
{
    public class Categories(IcategoriesService service) : EndpointsAsync.WithRequest<UpdateRequest>.WithActionResult
    {
        private readonly IcategoriesService _service = service;

        [HttpPut(Routes.CategoriesRoutes.Update)]
        public override async Task<ActionResult> HandleAsync(UpdateRequest request, CancellationToken cancellationToken = default)
        {
            var oData = new CategoriesOpprationConttract(request.Categorybody.Name , request.Categorybody.Description);
            await _service.UpdateCategory(request.CategoryId, oData);
            return Ok(oData);
        }
    }
}
