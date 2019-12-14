using System;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext
{
    public class Profile : IProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GitProvider GitProvider { get; set; }
    }

    public class Repository
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public enum GitProvider
    {
        Github,
        Bitbucket,
    }

    /// <summary>
    /// Added By Ahmet Oğuz
    /// </summary>
    public interface IProfile
    {

    }
}
