using Microsoft.EntityFrameworkCore;
using WebAccountant.DAOs;
using WebAccountant.ModelsBase;
using WebAccountant.Repository;
using WebAccountant.Repository.Implement;

namespace WebAccountant
{
    public static class ExtentionService
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<UnitOfWork>();
            services.AddScoped<IKtdmRepo, KtdmRepo>();
            return services;
        }
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<TIENHIEU2024Context>(options =>
            {
                options.UseSqlServer(GetConnectionString());
            });
            return services;
        }

        private static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings"];
        }
    }
}
