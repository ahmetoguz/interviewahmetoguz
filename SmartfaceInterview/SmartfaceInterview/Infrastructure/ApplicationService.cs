using System;
using System.Collections.Generic;
using System.Linq;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Repository;
using SmartfaceInterview.Infrastructure.QueueBoundedContext.Service;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Bitbucket;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Factory;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Github;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service.Repository;

namespace SmartfaceInterview.Infrastructure
{
    public class ApplicationService : IApplicationService
    {
        private readonly IRepositoryService _repositoryService;
        private readonly IProfileRepository _profileRepository;
        private readonly IClientFactoryService _clientFactoryService;
        private readonly IQueService _queueService;
        private readonly IQueueRepository _queueRepository;

        public ApplicationService(IRepositoryService repositoryService, IProfileRepository profileRepository,
            IClientFactoryService clientFactoryService, IQueService queueService, IQueueRepository queueRepository)
        {
            this._repositoryService = repositoryService;
            this._profileRepository = profileRepository;
            this._clientFactoryService = clientFactoryService;
            this._queueService = queueService;
            this._queueRepository = queueRepository;
        }

        public void DispatchQueue()
        {
            this._queueService.DispatchQueue();
        }

        public IEnumerable<Repository> GetRepositoriesByProfileId(Guid profileId)
        {
            List<Repository> _listRepository = new List<Repository>();

            var profile = this._profileRepository.GetProfileById(profileId);
            var clientFactory = this._clientFactoryService.GetClientFactory(profile);
            this._repositoryService.ClientFactory = clientFactory;
            var clientRepositories = this._repositoryService.GetClientRepositories();

            if (clientFactory is GithubFactory)
            {
                clientRepositories.Cast<GithubRepository>().ToList().ForEach(item =>
                {
                    _listRepository.Add(new Repository() { Id = Convert.ToString(item.RepositoryId), Name = item.Name });
                });
            }
            else
            {
                clientRepositories.Cast<BitbucketRepository>().ToList().ForEach(item =>
                {
                    _listRepository.Add(new Repository() { Id = item.RepoId, Name = item.Name });
                });
            }

            return _listRepository;
        }



    }

}
