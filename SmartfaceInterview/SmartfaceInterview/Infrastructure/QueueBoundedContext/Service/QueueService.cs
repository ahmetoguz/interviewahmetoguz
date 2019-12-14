using SmartfaceInterview.Infrastructure.QueueBoundedContext.Model;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Repository;
using System;
using System.Linq;

namespace SmartfaceInterview.Infrastructure.QueueBoundedContext.Service
{
    public class QueueService : IQueService
    {
        private readonly IQueueRepository _queueRepository;

        public QueueService(IQueueRepository queueRepository)
        {
            this._queueRepository = queueRepository;
        }
        public decimal CalculateQueueItemCount(Queue queue)
        {
            decimal queueCount = queue.QueueItems.Count();
            if (queue.Priority == 1)
                queueCount = (queueCount / 3) * 2;
            else
                queueCount = (queueCount / 3) * 1;
            return Math.Round(queueCount);
        }

        public void ConsumeQ(Queue[] queues)
        {
            for (int qindex = 0; qindex < queues.Count(); qindex++)
            {
                if (queues[qindex].QueueItems.Count() == 1)
                {
                    ProcessQueueItem(queues[qindex].QueueItems.Peek());
                    queues[qindex].QueueItems.Dequeue();
                }
                else
                {
                    var calculatedQitemCount = CalculateQueueItemCount(queues[qindex]);
                    int itemIndex = 0;
                    while (itemIndex < calculatedQitemCount)
                    {
                        //ProcessQueueItem() metoduna pass ediyoruz. 
                        ProcessQueueItem(queues[qindex].QueueItems.Peek());

                        //Q dan kaldır.
                        queues[qindex].QueueItems.Dequeue();

                        itemIndex++;
                    }
                }
            }

            //Q'da kayıt var ise consume etmeye devam et.
            var isExistsQueueItem = queues.Any(q => q.QueueItems.Count() > 0);
            if (isExistsQueueItem)
                ConsumeQ(queues);
        }

        // This method will be called scheduled. 
        // Every company has own queue
        // We need consume this queue according to priorities
        // But company that priory is greater than other should not block other queue. It is not related multi threading.
        // For example
        // Time - Company -  Priority    -   Queue Items
        //  t1      A           1               30
        //  t1      B           2               30
        //  t2      A           1               20
        //  t2      B           2               10
        public void DispatchQueue()
        {
            var queues = this._queueRepository.GetQueues();
            ConsumeQ(queues);
        }

        //belirli aralıklarla queue item ProcessQueueItem metoduna parametre  gönderilerek tüketilecektir.
        public void ProcessQueueItem(QueueItem item)
        {
            Console.WriteLine("Message Id: {0}", item.Id);
        }
    }
}
