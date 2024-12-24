using CraftI_2.Core.interfaces;
using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ2.Api.Endpoints.Categories.read.byid
{
    public class Categories(IcategoriesService services) : EndpointsAsync.WithRequest<ReadbyIdRequest>.WithActionResult<ReadByIdResponce>
    {
        private readonly IcategoriesService _categoriesService = services;
        [HttpGet(Routes.CategoriesRoutes.ReadById)]
        public override async Task<ActionResult<ReadByIdResponce>> HandleAsync(ReadbyIdRequest request, CancellationToken cancellationToken = default)
        {
            var oData = await _categoriesService.ReadCategorybyId(request.categoryId);
            var oResult = new ReadByIdResponce(oData);
            return Ok(oResult);
        }


       
    }
}
