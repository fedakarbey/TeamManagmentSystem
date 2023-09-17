using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.UI.ApiService;
using TeamManagment.UI.Models.Core.Context;
using TeamManagment.UI.Models.DAL.Concrete;
using TeamManagment.UI.Models.DAL.Interfaces;

namespace TeamManagment.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddHttpClient<KisiBilgiApiService>(a => a.BaseAddress = new Uri("http://localhost:12440/"));

            services.AddDbContext<MyDBContext>(options =>
            {
                options.UseSqlServer("Server=.;Database=TeamManagment;uid=sa;pwd=123456");
            });

            services.AddScoped<ITakimDAL, TakimDAL>();
            services.AddScoped<IKisiDAL, KisiDAL>();
            services.AddScoped<ITakimKisiDAL, TakimKisiDAL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Team}/{action=Index}/{id?}");
            });
        }
    }
}
