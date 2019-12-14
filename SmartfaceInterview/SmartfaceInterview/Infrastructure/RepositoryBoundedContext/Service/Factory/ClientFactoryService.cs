using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service
{
    public class ClientFactoryService : IClientFactoryService
    {
        ClientFactory _factory;
        public ClientFactory GetClientFactory(Profile profile)
        {
            if (profile.GitProvider == GitProvider.Bitbucket)
                _factory = new BitbucketFactory();
            if (profile.GitProvider == GitProvider.Github)
                _factory = new GithubFactory();
            
            return _factory;
        }
    }
}
