using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service
{
    public interface IClientFactoryService
    {
        ClientFactory GetClientFactory(Profile profile);
    }
}