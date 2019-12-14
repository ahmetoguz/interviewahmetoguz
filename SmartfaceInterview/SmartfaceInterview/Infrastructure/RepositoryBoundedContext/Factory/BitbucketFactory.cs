using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory
{
    public class BitbucketFactory : ClientFactory
    {
        public override Client GetClient()
        {
            return new BitbucketClient();
        }
    }
}
