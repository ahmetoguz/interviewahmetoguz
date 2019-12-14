using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service
{
    public interface IProfileRepository
    {
        public Profile GetProfileById(Guid id);

    }
}
