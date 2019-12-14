using SmartfaceInterview.Infrastructure.RepositoryBoundedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure
{
    public interface IApplicationService
    {
        IEnumerable<Repository> GetRepositoriesByProfileId(Guid profileId);

        void DispatchQueue();

    }
}
