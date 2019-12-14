using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartfaceInterview.Infrastructure;
using SmartfaceInterview.Infrastructure.QueueBoundedContext;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Repository;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Service;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service.Repository;

namespace SmartfaceInterview
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
            services.AddControllers(options => options.EnableEndpointRouting = false);
            services.AddScoped<IApplicationService, ApplicationService>();
            services.AddScoped<IClientFactoryService, ClientFactoryService>();
            services.AddScoped<IRepositoryService, RepositoryService>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IQueService, QueueService>();
            services.AddScoped<IQueueRepository, QueueRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvc();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
