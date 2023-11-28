using BookingSystemApi.Application.Commands.Resource.Create;

namespace BookingSystemApi.Application.IRepositories;

public interface IResourceRepository
{
    void Create(CreateResourceCommand request);
}
