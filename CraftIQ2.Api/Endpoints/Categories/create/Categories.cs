using CraftI_2.Core.Entinty.Categories;
using CraftI_2.Core.interfaces;
using CraftIQ2.Shared.Contracts.Categories;
using huzcodes.Endpoints.Abstractions;
using huzcodes.Extensions.Exceptions;
using huzcodes.Persistence.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CraftIQ2.Api.Endpoints.Categories.create
{
    public class Categories(IcategoriesService services) : EndpointsAsync.WithRequest<CreateCategoriesRequset>.WithActionResult<CreateCategoriesResponse>


    {
        private readonly IcategoriesService _services = services;
        [HttpPost(Routes.CategoriesRoutes.BaseUrl)]
        public override async Task<ActionResult<CreateCategoriesResponse>> HandleAsync(CreateCategoriesRequset request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ResultException("request can't be null", (int)HttpStatusCode.BadRequest);
            }
            var oData = new CategoriesOpprationConttract(request.Name ,request.Description);
            var oReult = await _services.CreateCategory(oData);
            return Ok(new CreateCategoriesResponse(oReult.Name, oReult.Description));
        }
    }
}
