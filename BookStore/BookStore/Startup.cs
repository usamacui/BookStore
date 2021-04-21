using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // we use this below mentioned method for create a middle ware
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from my first middleware");

                await next(); //this next method transfer control to next method for compile it
            });

            app.Use(async (context, next) =>
                {
                await context.Response.WriteAsync("Hi this is second middle walre");
                    await next();
                });
                

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello Usama!");
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/ahmad", async context =>
                {
                    await context.Response.WriteAsync("Ahmad is here");
                });
            });
                
        }
    }
}
