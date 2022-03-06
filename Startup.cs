using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using LeitorCBF.LeitorCSV.CBFDataService;
using LeitorCBF.LeitorCSV.Repository;

namespace LeitorCBF
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
            services.AddMvc();

            string connectionString = Configuration.GetConnectionString("Banco1");

            services.AddDbContext<LeitorCBF.ApplicationContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddTransient<IDataService, DataService>();
            services.AddTransient<ICBFRepository, CBFRepository>();
            services.AddTransient<ILeitorCSVModelRepository, LeitorCSVModelRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            IServiceProvider serviceProvider)
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

            serviceProvider.GetService<IDataService>().IncicializaDB();
        }
    }
}
