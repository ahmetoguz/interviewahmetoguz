using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory
{
    public abstract class ClientFactory
    {
        public abstract Client GetClient();
    }
}
