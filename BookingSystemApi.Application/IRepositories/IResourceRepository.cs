using BookingSystemApi.Application.Resource.Create;

namespace BookingSystemApi.Application.IRepositories;

public interface IResourceRepository
{
    void Create(CreateResourceCommand request);
}
