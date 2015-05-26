using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace MVCTest
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<MyLibrary.Class1>();
            services.AddTransient<MyLibrary.IRepService, MyLibrary.RepService>();
            ////services.AddSingleton<MyLibrary.IRepService, MyLibrary.RepService>();
            ////services.AddScoped<MyLibrary.IRepService, MyLibrary.RepService>();
        }

        public void Configure(IApplicationBuilder app)
        {
            //// MVC DI Test
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "about",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Test", action = "Index", id = "1" });
            });

            ////// Error Page
            //app.UseErrorPage();
            //app.Run(async (context) =>
            //{
            //    throw new Exception("test error page");
            //    await context.Response.WriteAsync("Hello World!");
            //});


        }
    }
}
