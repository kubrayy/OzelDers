using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OzelDers.Business.Abstract;
using OzelDers.Business.Concrete;
using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete;

namespace OzelDers.WebUI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        var sqliteConnection = builder.Configuration.GetConnectionString("SqliteCon");
        builder.Services.AddDbContext<MyAppContext>(options => options.UseSqlite(sqliteConnection));

        builder.Services.AddScoped<IInstructorRepository, EfCoreInstructorRepository>();
        builder.Services.AddScoped<ILanguageRepository, EfCoreLanguageRepository>();
        builder.Services.AddScoped<IInstructorService, InstructorManager>();
        builder.Services.AddScoped<ILanguageService, LanguageManager>();


        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "instructors",
            pattern: "instructors/{language?}",
            defaults: new { controller = "Instructor", action = "Index" }
        );

       app.MapControllerRoute(
           name: "languages",
           pattern: "language/{url?}",
           defaults: new { controller = "OzelDers", action = "List" }
        );

        app.MapControllerRoute(
         name: "details",
         pattern: "instructor/{url?}",
         defaults: new { controller = "OzelDers", action = "Details" }
        );

        app.MapControllerRoute(
         name: "howitworks",
         pattern: "howitworks",
         defaults: new { controller = "OzelDers", action = "HowItWorks" }
        );

        app.MapControllerRoute(
          name: "search",
          pattern: "search",
          defaults: new { controller = "OzelDers", action = "Search" }
        );

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
