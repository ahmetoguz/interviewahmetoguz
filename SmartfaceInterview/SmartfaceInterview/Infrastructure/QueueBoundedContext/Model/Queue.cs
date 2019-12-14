using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.QueueBoundedContext.Model
{
  

    public class Queue
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        //public QueueItem[] QueueItems { get; set; }
        public Queue<QueueItem> QueueItems { get; set; }
    }

    public class QueueItem
    {
        public Guid Id { get; set; }
    }
}
