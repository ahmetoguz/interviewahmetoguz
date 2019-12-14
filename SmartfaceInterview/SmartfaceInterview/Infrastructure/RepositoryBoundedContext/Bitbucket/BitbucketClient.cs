namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Bitbucket
{
    public class BitbucketClient
    {
        #region Added By Smartface
        public BitbucketRepository[] GetRepositories()
        {
            return new BitbucketRepository[]
            {
                new BitbucketRepository()
                {
                    RepoId = "1",
                    Name = "Repo1-Bitbucket"
                },
                new BitbucketRepository()
                {
                    RepoId = "2",
                    Name = "Repo2-Bitbucket"
                },
            };
        }
        #endregion

    }
}