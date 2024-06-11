using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Options;

namespace WebAccountant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddJsonOptions(options => {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                });
            builder.Services.AddDependencyInjection();
            builder.Services.AddDatabase();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
            });
            builder.Services.Configure<FormOptions>(options =>
            {
                options.KeyLengthLimit = int.MaxValue;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
           
            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");
                
            app.Run();
        }
    }
}