using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service.Repository
{
    public interface IRepositoryService 
    {
        IList<BaseRepository> GetClientRepositories();

        ClientFactory GetClientFactory(Profile profile);

        ClientFactory ClientFactory { get; set; }
    }
}
