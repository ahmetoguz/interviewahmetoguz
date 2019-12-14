using SmartfaceInterview.Infrastructure.QueueBoundedContext.Model;
using System;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.QueueBoundedContext.Repository
{
    public interface IQueueRepository
    {
        Queue[] GetQueues();
    }
}
