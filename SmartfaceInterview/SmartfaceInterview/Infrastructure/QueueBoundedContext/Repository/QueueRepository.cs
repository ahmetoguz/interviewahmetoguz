using SmartfaceInterview.Infrastructure.QueueBoundedContext.Model;
using System;
using System.Collections.Generic;


namespace SmartfaceInterview.Infrastructure.QueueBoundedContext.Repository
{
    public class QueueRepository : IQueueRepository
    {
        public Queue[] GetQueues()
        {
            Queue[] Queues = new Queue[]
            {
                 new Queue()
                    {
                        Id = Guid.NewGuid(),
                        Priority = 1,
                        Name = "A Company",
                        //QueueItems = new QueueItem[]
                        QueueItems = new Queue<QueueItem>()

                    },
                    new Queue()
                    {
                        Id = Guid.NewGuid(),
                        Priority = 2,
                        Name = "B Company",
                        //QueueItems = new QueueItem[] 
                        QueueItems = new Queue<QueueItem>()
                    },
            };

            return BindToQueueItem(Queues);

        }

        public Queue[] BindToQueueItem(Queue[] queues)
        {
            queues[0].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });
            queues[0].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });
            queues[0].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });
            queues[0].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });

            queues[1].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });
            queues[1].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });
            queues[1].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });
            queues[1].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });
            queues[1].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });
            queues[1].QueueItems.Enqueue(new QueueItem() { Id = Guid.NewGuid() });

            return queues;
        }

      
    }
}




