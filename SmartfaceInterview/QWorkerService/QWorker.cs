using Microsoft.Extensions.Hosting;
using SmartfaceInterview.Infrastructure;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QWorkerService
{
    public class QWorker : BackgroundService
    {
        IApplicationService _applicationService;

        public QWorker(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _applicationService.DispatchQueue();
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
