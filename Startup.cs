using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using lll.Models;
using Prometheus;

namespace aPI2
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
            services.AddControllers();
         
            services.AddDbContext<TaskDBContext>(options =>
                        options.UseSqlServer("Server=tcp:tbirdclanwish.database.windows.net,1433;Initial Catalog=Database1;Persist Security Info=False;User ID=tbirdclanwish;Password=Tfish12!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
            services.AddRazorPages();
         
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
       
          
            //app.UseHttpsRedirection();

            app.UseRouting();
            app.UseHttpMetrics();
            app.UseAuthorization();
           // app.UseMetricServer();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapMetrics();
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
           
        }
    }
}
