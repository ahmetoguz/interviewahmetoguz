using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Github;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory
{
    public class GithubClient : Client
    {
        public override List<BaseRepository> GetRepositories()
        {
            this.Repositories.Add(new GithubRepository() { RepositoryId = Guid.NewGuid(), Name = "Repo1" });
            this.Repositories.Add(new GithubRepository() { RepositoryId = Guid.NewGuid(), Name = "Repo2" });

            return this.Repositories;
        }

    }
}



