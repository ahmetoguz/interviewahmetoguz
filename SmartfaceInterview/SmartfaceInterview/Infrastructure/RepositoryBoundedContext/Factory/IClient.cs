using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory
{
    public abstract class Client
    {
        public abstract List<BaseRepository> GetRepositories();

        //base repositories
        private List<BaseRepository> _repositories = new List<BaseRepository>();

        public List<BaseRepository> Repositories
        {
            get { return _repositories; }
        }

    }
}
