using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using charbucks.Models;

namespace charbucks
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            using (var context = new MyDbContext()) {
                context.Database.EnsureCreated();
            }
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // seed data. this is not how we would typically do this, but
            // we just need some data for demonstration purposes
            var db = new MyDbContext();
            if (!db.Coffees.Any())
            {
                var coffees = new List<Coffee>() {
                    new Coffee() { ID = 1, Origin = "Costa Rica", Roast = "Medium" },
                    new Coffee() { ID = 2, Origin = "Ethiopia", Roast = "Medium" },
                    new Coffee() { ID = 3, Origin = "Tanzanian Peaberry", Roast = "Light" }
                };

                db.Coffees.AddRange(coffees);
                db.SaveChanges();
            }
        }
    }
}
