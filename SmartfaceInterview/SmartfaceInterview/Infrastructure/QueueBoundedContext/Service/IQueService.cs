
using SmartfaceInterview.Infrastructure.QueueBoundedContext;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Model;

namespace SmartfaceInterview.Infrastructure.QueueBoundedContext.Service
{
    public interface IQueService
    {
        decimal CalculateQueueItemCount(Queue queue);
        void DispatchQueue();

        void ProcessQueueItem(QueueItem item);

        void ConsumeQ(Queue[] queues);
    }
}
