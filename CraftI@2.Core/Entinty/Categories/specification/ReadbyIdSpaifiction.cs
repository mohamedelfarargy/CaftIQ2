using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftI_2.Core.Entinty.Categories.specification
{
    public class ReadbyIdSpaifiction :SingleResultSpecification<Category>
    {
        public ReadbyIdSpaifiction(Guid categoryId)
        {
            Query.Where(o => o._CategoryId == categoryId);
        }
    }
}
