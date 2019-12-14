using System;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Github
{
    public class GithubClient
    {
        public GithubRepository[] GetRepositories()
        {
            return new GithubRepository[]
            {
                new GithubRepository()
                {
                    RepositoryId = Guid.NewGuid(),
                    Name = "Repo1"
                },
                new GithubRepository()
                {
                    RepositoryId = Guid.NewGuid(),
                    Name = "Repo2"
                },
            };
        }
      

    }
}