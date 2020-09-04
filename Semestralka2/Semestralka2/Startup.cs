using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Semestralka2.Hubs;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Repos;

namespace Semestralka2
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
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<ApplicationContext>(options =>
                options.UseSqlServer(connection, b => b.MigrationsAssembly("SemestralkaDataControl")));
            services.AddScoped<IAnswersRepo, AnswersRepo>();
            services.AddScoped<IQuestionsRepo, QuestionsRepo>();
            services.AddScoped<IProductsAndCategoriesRepo, ProductsAndCategoriesRepo>();
            services.AddCors();
            services.AddSignalR();
            services.AddControllers();
            services.AddRazorPages();
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
                app.UseExceptionHandler("/Error");
            }
            app.UseCors(builder =>
            builder.WithOrigins("http://localhost:3000"));

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<MainHub>("/hub");
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
    }
}
