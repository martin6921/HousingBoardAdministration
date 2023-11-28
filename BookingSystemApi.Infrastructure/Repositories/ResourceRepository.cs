using BookingSystemApi.Application.Commands.Resource.Create;
using BookingSystemApi.Application.IRepositories;

namespace BookingSystemApi.Infrastructure.Repositories;

public class ResourceRepository : IResourceRepository
{
    void IResourceRepository.Create(CreateResourceCommand request)
    {
        throw new NotImplementedException();
    }
}
