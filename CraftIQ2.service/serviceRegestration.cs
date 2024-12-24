using CraftI_2.Core.interfaces;
using CraftIQ2.service.Categories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ2.service
{
   public static class ServiceRegestration
    {
        public static void AddServicesRegistrations(this IServiceCollection services)
        {
            services.AddScoped<IcategoriesService,CategoriesService>();
        }
    }
}
