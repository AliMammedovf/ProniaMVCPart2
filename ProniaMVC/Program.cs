using Microsoft.EntityFrameworkCore;
using ProniaMVC.Business.Service.Abstract;
using ProniaMVC.Business.Service.Concret;
using ProniaMVC.Core.RepsitoryAbstract;
using ProniaMVC.Data.DAL;
using ProniaMVC.Data.RepositoryCancret;
using ProniaMVC.ViewServices;

namespace ProniaMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("Default")); } );

            
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
            builder.Services.AddScoped<ITagRepository, TagRepository>();
            builder.Services.AddScoped<ITagService, TagService>();
            builder.Services.AddScoped<ShopService>();
            builder.Services.AddScoped<ShopTagService>();
            builder.Services.AddScoped<IFeatureService, FeatureService>();
            builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}