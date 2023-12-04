using BookingSystemApi.Application.Commands.Resource.Create;
using BookingSystemApi.Application.Commands.Resource.Delete;
using BookingSystemApi.Application.Queris.Resource.Dto;
using BookingSystemApi.Domain.Entities;

namespace BookingSystemApi.Application.IRepositories;

public interface IResourceRepository
{
    void Create(CreateResourceCommand request);
       
    void Delete(DeleteResourceCommad request);
    ResourceGetQueryResultDto Get(Guid id);
    IEnumerable<ResourceGetAllQueryResultDto> GetAll();
    ResourceEntity Load(Guid id);

    void Update(ResourceEntity request);
}

