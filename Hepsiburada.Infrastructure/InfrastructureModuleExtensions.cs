using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada.Domain.Repository_Interfaces.EfRepositories;
using Hepsiburada.Infrastructure.Contexts;
using Hepsiburada.Infrastructure.Repositories.EfRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Hepsiburada.Infrastructure
{
    public static class InfrastructureModuleExtensions
    {
        public static IServiceCollection AddInfrastructureModule(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfDbContext>(
                options => options.UseNpgsql(configuration.GetConnectionString("Default"),
                    b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName))
            );

            //services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings")[]);

            //services.AddSingleton<IMongoDbSettings>(serviceProvider =>
            //    serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

            services.AddScoped<IEfUserRepository, EfUserRepository>();
            services.AddScoped<IEfItemRepository, EfItemRepository>();
            services.AddScoped<IEfUserListRepository, EfUserListRepository>();
            services.AddScoped<IEfProductRepository, EfProductRepository>();
            return services;
        }
    }
}
