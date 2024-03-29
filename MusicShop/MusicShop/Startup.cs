using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MusicShop.Data;
using MusicShop.Repository;
using System.IO;

namespace MusicShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MusicShopContext>(
                options => options.UseSqlServer("Server=.;Database=MusicShop;Integrated Security=True"));

            services.AddControllersWithViews();
            //nie trzeba za ka�dym razem �adowa� solucji
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
            services.AddScoped<VinylRepository, VinylRepository>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
            endpoints.MapDefaultControllerRoute();
            //endpoints.MapControllerRoute(
            //    name: "Default",
            //    pattern: "musicApp/{controller=Home}/{action=Index}/{id?}");               
            });         
        }
    }
}
