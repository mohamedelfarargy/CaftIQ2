using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ2.Shared.Contracts.Categories
{
    public class CategoriesOpprationConttract
    {
       
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // relation with products
      
        public CategoriesOpprationConttract(string name, string description)
        {
            
            Name = name;
            Description = description;
        
        }
    }
}
