using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartfaceInterview.Infrastructure;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Repository;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Service;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service.Repository;

namespace QWorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    
                    services.AddTransient<IApplicationService, ApplicationService>();
                    services.AddTransient<IRepositoryService, RepositoryService>();
                    services.AddTransient<IProfileRepository, ProfileRepository>();
                    services.AddTransient<IClientFactoryService, ClientFactoryService>();
                    services.AddTransient<IQueService, QueueService>();
                    services.AddTransient<IQueueRepository, QueueRepository>();

                    services.AddHostedService<QWorker>(); 
                });
    }
}
