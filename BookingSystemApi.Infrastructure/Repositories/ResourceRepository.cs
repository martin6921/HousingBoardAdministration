using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Resource.Create;

namespace BookingSystemApi.Infrastructure.Repositories;

public class ResourceRepository : IResourceRepository
{
    void IResourceRepository.Create(CreateResourceCommand request)
    {
        throw new NotImplementedException();
    }
}
