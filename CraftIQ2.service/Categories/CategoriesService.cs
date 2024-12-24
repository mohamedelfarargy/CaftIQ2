using CraftI_2.Core.Entinty.Categories;
using CraftI_2.Core.Entinty.Categories.specification;
using CraftI_2.Core.interfaces;
using CraftIQ2.Shared.Contracts.Categories;
using huzcodes.Extensions.Exceptions;
using huzcodes.Persistence.Interfaces.Repositories;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ2.service.Categories
{
    public class CategoriesService(IRepository<Category> _repository) : IcategoriesService
    {
        private readonly IRepository<Category> repository = _repository;
        public async ValueTask<CategoriesOpprationConttract> CreateCategory(CategoriesOpprationConttract conract)
        {
            var oData = new Category(conract.Name,
                                      conract.Description);
            var oResult = await _repository.AddAsync(oData);

            return new CategoriesOpprationConttract(oResult.Name,
                                                   oResult.Description);
        }

        public async ValueTask DeleteCategory(Guid categoryId)
        {
            var oReadByIdSpec = new ReadbyIdSpaifiction(categoryId);
            var oResult = await _repository.FirstOrDefaultAsync(oReadByIdSpec);
            if (oResult != null)
                await _repository.DeleteAsync(oResult);
            else throw new ResultException("You can't delete object that is not exit.", (int)HttpStatusCode.Forbidden);
        }


        public async ValueTask<List<CategoriesContract>> ReadCategory()
        {
            var oReadSpec = new Readspifiction();
            var oData = await _repository.ListAsync(oReadSpec);
            if (oData != null && oData.Count > 0)
            {
                var oResult = oData.Select(o => new CategoriesContract(o._CategoryId,
                                                                       o.Name,
                                                                       o.Description,
                                                                       o.CreatedBy,
                                                                       o.ModifiedBy,
                                                                       o.CreatedOn,
                                                                     o.ModifiedOn)).ToList();
                return oResult;
            }
            else return new List<CategoriesContract>();
        }

        public async ValueTask<CategoriesContract> ReadCategorybyId(Guid categoryId)
        {
            var oReadByIdSpec = new ReadbyIdSpaifiction(categoryId);
            var oResult = await _repository.FirstOrDefaultAsync(oReadByIdSpec);
            if (oResult != null)
                return new CategoriesContract(oResult._CategoryId, oResult.Name, oResult.Description, oResult.CreatedBy, oResult.ModifiedBy, oResult.CreatedOn, oResult.ModifiedOn);

            else throw new ResultException("You can't delete object that is not exit.", (int)HttpStatusCode.NotFound);
        }


        //  new CategoriesOpprationConttract(oResult._CategoryId , oResult.Name , oResult.Description, oResult.CreatedBy, oResult.ModifiedBy    , oResult.CreatedOn, oResult.ModifiedOn);




        public async ValueTask UpdateCategory(Guid categoryId, CategoriesOpprationConttract conract)
        {
            var oReadByIdSpec = new ReadbyIdSpaifiction(categoryId);
            var oResult = await _repository.FirstOrDefaultAsync(oReadByIdSpec);
            if (oResult != null)
            {
                oResult.updateCategory (conract!.Name, conract.Description,Guid.NewGuid());

               
                await _repository.UpdateAsync(oResult);

            }

            else throw new ResultException("This object is not exit", (int)HttpStatusCode.NotFound);
        }

     
    }
}

