using SmartfaceInterview.Infrastructure.RepositoryBoundedContext.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartfaceInterview.Infrastructure.RepositoryBoundedContext
{
    public class ProfileRepository : IProfileRepository
    {
        public List<Profile> _profileList;
        public ProfileRepository()
        {
            _profileList = new List<Profile>()
            {
                new Profile{ Id = Guid.Parse("81b8a39a-a077-4a44-a786-1f7a979fe054"), Name = "Profile1", GitProvider = GitProvider.Bitbucket},
                new Profile{ Id = Guid.Parse("fcd93abe-02af-44fa-80f2-54c35acebdee"), Name = "Profile2", GitProvider = GitProvider.Github},
                new Profile{ Id = Guid.Parse("65de93ff-8341-4e26-81c6-de1ba2a2d8ed"), Name = "Profile3", GitProvider = GitProvider.Github},
                new Profile{ Id = Guid.Parse("54ded6d0-f5bc-4518-acdf-aab7707856e1"), Name = "Profile4", GitProvider = GitProvider.Bitbucket},

            };

        }
        public Profile GetProfileById(Guid id)
        {
            return _profileList.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}