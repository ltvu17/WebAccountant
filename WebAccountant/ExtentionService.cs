using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebAccountant.DAOs;
using WebAccountant.Models;
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
            services.AddScoped<IKtcnsRepo, KtcnRepo>();
            services.AddScoped<IKtdtpnsRepo, KtdtpnRepo>();
            services.AddScoped<IKtlctgRepo, KtlctgRepo>();
            services.AddScoped<IKtscRepo, KtscRepo>();
            services.AddScoped<IKttkRepo, KttkRepo>();
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
        public static KtdmDTO KTDMMapper(this Ktdm baseEntity)
        {
            return new KtdmDTO()
            {
                Matk = baseEntity.Matk,
                Madm = baseEntity.Madm,
                Donvi = baseEntity.Donvi,
                Tendm = baseEntity.Tendm,
                Dgban1 = baseEntity.Dgban1,
                TonTDv1 = baseEntity.TonTDv1,
                Soluong = 0,
            };
        }
    }
}
