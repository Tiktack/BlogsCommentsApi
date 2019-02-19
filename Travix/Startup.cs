using BusinessLayer;
using Common;
using DataLayer;
using DataLayer.Interfaces;
using DataLayer.Interfaces.Repositories;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

// ReSharper disable once IdentifierTypo
namespace Travix
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Test API",
                    Description = "ASP.NET Core Web API for Travix"
                });
            });
            services.AddDbContext<BaseContext>();

            RegisterDependencies(services);
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1");
            });
        }
        private static void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IAppSettings, AppSettings>();
        }
    }
}
