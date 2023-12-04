using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Resource.Dto;
using BookingSystemApi.Application.Queris.Resource.Interface;

namespace BookingSystemApi.Application.Queris.Resource.Implementation
{
    public class ResourceGetAllQuery : IResourceGetAllQuery
    {
        private readonly IResourceRepository _resourceRepository;

        public ResourceGetAllQuery(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        IEnumerable<ResourceGetAllQueryResultDto> IResourceGetAllQuery.GetAll()
        {
            return _resourceRepository.GetAll();
        }
    }
}
