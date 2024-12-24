using CraftIQ2.Shared.Contracts.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftI_2.Core.interfaces
{
    public interface IcategoriesService
    {
        ValueTask<CategoriesOpprationConttract> CreateCategory(CategoriesOpprationConttract conract);
        ValueTask<List<CategoriesContract>> ReadCategory();
        ValueTask<CategoriesContract> ReadCategorybyId(Guid categoryId);
        ValueTask UpdateCategory(Guid categoryId, CategoriesOpprationConttract conract );
        ValueTask DeleteCategory(Guid categoryId );
    }
}
