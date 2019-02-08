using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Zicos_Garage.Web
{
    /// <summary>
    /// Startup class
    /// </summary>
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // dependancy injection (default by microsoft)
            // service changeable later but DI has to be used
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // developer use only
            // goto: project -> properties -> enviroment variables
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // enables using static files
            app.UseStaticFiles();

            // enables using MVC - Model View Controllers
            app.UseMvc(configuration => {

                // default behaviour
                configuration.MapRoute("Default", "{controller}/{action}/{id?}", 
                    new { controller = "App", Action = "Index" });
            });
        }
    }
}
