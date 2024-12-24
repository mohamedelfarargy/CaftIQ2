using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftI_2.Core.Entinty.Categories.specification
{
   public class Readspifiction : Specification<Category>
    {
        public Readspifiction()
        {
            Query.Where(o => o.Id != 0);
        }
    }
}
