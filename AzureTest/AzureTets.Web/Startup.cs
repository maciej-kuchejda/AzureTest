using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureTest.DataContext.Repository;
using AzureTets.Web.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DbContext = AzureTest.DataContext.Context.DbContext;

namespace AzureTets.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc();

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new ViewLocationExpander());
            });

            services.AddDbContext<DbContext>(options =>
            {
                options.UseSqlite("Data Source=Database.db");
            });

            services.AddScoped<ICardRepository, CardRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
            
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}");
            //});
            
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //app.UseMvc(
            //    routes =>
            //    {
            //        routes.MapRoute(
            //            name: "Index",
            //            template: "/",
            //            defaults: new { controller = "Home", action = "Index" }
            //        );
            //    }
            //);
        }
    }
}
