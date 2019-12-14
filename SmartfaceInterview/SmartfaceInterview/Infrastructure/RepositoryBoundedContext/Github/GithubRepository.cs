using System;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Github
{
    /// <summary>
    /// Updated by Ahmet OĞUZ
    /// GithubRepository class derivved from BaseRepository
    /// </summary>
    public class GithubRepository : BaseRepository
    {
        public Guid RepositoryId { get; set; }
    }

    ///// <summary>
    ///// Added By Smartface
    ///// </summary>
    //public class GithubRepository
    //{
    //    public Guid RepositoryId { get; set; }
    //    public string Name { get; set; }
    //}
}