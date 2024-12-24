using CraftI_2.Core.interfaces;
using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ2.Api.Endpoints.Categories.read
{
    public class Categories(IcategoriesService services) : EndpointsAsync.WithoutRequest.WithActionResult<ReadCategoriesResponse>

    {
        private readonly IcategoriesService _categoriesService = services;

        [HttpGet(Routes.CategoriesRoutes.BaseUrl)]

        public override async Task<ActionResult<ReadCategoriesResponse>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var oData = await _categoriesService.ReadCategory();
            var oResult = oData.Select(o => new ReadCategoriesResponse(o))
                               .ToList();
            return Ok(oResult);
        }
    }
}
