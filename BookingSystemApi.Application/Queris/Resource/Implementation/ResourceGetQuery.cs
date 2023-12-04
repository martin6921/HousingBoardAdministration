using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Resource.Dto;
using BookingSystemApi.Application.Queris.Resource.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Resource.Implementation
{
    public class ResourceGetQuery : IResourceGetQuery
    {
        private readonly IResourceRepository _resourceRepository;

        public ResourceGetQuery(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }
        ResourceGetQueryResultDto IResourceGetQuery.Get(Guid id)
        {
            return _resourceRepository.Get(id);
        }
    }
}
