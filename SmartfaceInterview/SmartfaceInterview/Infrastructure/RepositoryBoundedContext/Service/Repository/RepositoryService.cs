using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory;
using System;
using System.Collections.Generic;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service.Repository
{
    public class RepositoryService : IRepositoryService
    {
        public ClientFactory ClientFactory { get; set; }

        public IList<BaseRepository> GetClientRepositories()
        {
            return ClientFactory.GetClient().GetRepositories();
        }

        public ClientFactory GetClientFactory(Profile profile)
        {
            if (profile.GitProvider == GitProvider.Bitbucket)
                this.ClientFactory = new BitbucketFactory();
            if (profile.GitProvider == GitProvider.Github)
                this.ClientFactory = new GithubFactory();

            return this.ClientFactory;
        }



    }
}
