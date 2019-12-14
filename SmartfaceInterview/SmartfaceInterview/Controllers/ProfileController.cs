using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartfaceInterview.Infrastructure;
using SmartfaceInterview.Infrastructure.RepositoryBoundedContext;

namespace SmartfaceInterview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        IApplicationService _applicationService;
        public ProfileController(IApplicationService applicationService)
        {
            this._applicationService = applicationService;
        }

        [HttpGet("{id}")]
        public IEnumerable<Repository> Get(string id)
        {
           
            // Check that this method is correct
           var repositories = _applicationService.GetRepositoriesByProfileId(Guid.Parse(id));

           return repositories;
        }

       
    }
}
