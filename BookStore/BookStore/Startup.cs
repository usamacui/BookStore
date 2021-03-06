using BookStore.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class Startup
    {
        private object path;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookStoreContext>(
                options => options.UseSqlServer("Server=.;Database=BookStore;Integrated Security=True;"));  //Service for entity fram work database

            services.AddControllersWithViews(); // we have add this method for add controler class and for view also this method load the HomeControler 
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())                      //enviournment variable
            {
                app.UseDeveloperExceptionPage();
            }



            //// we use this below mentioned method for create a middle ware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my first middleware");

            //    await next(); //this next method transfer control to next method for compile it
            //});

            //app.Use(async (context, next) =>
            //    {
            //    await context.Response.WriteAsync("Hi this is second middle walre");
            //        await next();
            //    });

            app.UseStaticFiles();  //this method is use for useing static files e.g images css or js  from root location
            //app.UseStaticFiles(new StaticFileOptions() //and this metod is use for useing static files from other locations or isay use krny ka lea 1 folder create krna ho ga "MyStaticFiles" ka name sy
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory() + "MyStaticFiles")),
            //    RequestPath ="./MyStaticFiles"
            //});
                
            //----------------------------------------------------------------------------------------------------------------------------

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync(env.EnvironmentName);
            //    });
            //});

            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapDefaultControllerRoute();

                //endpoints.MapControllerRoute(
                //    name: "Default",
                //    pattern: "bookApp/{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/ahmad", async context =>
            //    {
            //        await context.Response.WriteAsync("Ahmad is here");
            //    });
            //});
                
        } 
    }
}
