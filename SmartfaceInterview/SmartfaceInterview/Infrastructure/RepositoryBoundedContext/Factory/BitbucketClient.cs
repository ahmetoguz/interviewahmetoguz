using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Bitbucket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory
{
    public class BitbucketClient : Client
    {
        public override List<BaseRepository> GetRepositories()
        {
            this.Repositories.Add(new BitbucketRepository() { RepoId = "1", Name = "Repo1-Bitbucket" });
            this.Repositories.Add(new BitbucketRepository() { RepoId = "2", Name = "Repo2-Bitbucket" });

            return this.Repositories;
        }
    }
}

