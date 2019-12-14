using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext
{
    public abstract class RepositoryClientFactory
    {
        public abstract Client GetRepositoryClient();

    }
}
