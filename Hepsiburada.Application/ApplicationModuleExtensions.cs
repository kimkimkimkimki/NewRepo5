using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Application.ServiceInterfaces;
using Hepsiburada.Application.Services;
using Hepsiburada.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Hepsiburada.Application
{
    public static class ApplicationModuleExtensions
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserListService, UserListService>();
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddInfrastructureModule(configuration);

            return services;
        }
    }
}
