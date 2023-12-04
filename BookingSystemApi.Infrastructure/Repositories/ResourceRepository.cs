using BookingSystemApi.Application.Commands.Resource.Create;
using BookingSystemApi.Application.Commands.Resource.Delete;
using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Resource.Dto;
using BookingSystemApi.Domain.Entities;
using BookingSystemApi.SqlServerContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace BookingSystemApi.Infrastructure.Repositories;

public class ResourceRepository : IResourceRepository
{
    private readonly BookingSystemDbContext _context;

    public ResourceRepository(BookingSystemDbContext context)
    {
        this._context = context;
    }
    
    ResourceEntity IResourceRepository.Load(Guid id)
    {
        var model = _context.ResourceEntities.FirstOrDefault(x => x.Id == id);
        return model == null ? throw new Exception("Der blev ingen resource fundet") : model;
    }
    void IResourceRepository.Update(ResourceEntity request)
    {
        _context.Update(request);
        _context.SaveChanges();
    }
    void IResourceRepository.Create(CreateResourceCommand request)
    {
        var model = new ResourceEntity
        {
            Description = request.Description,
            Specification = request.Specification,
            Price = request.Price
            
        };
        _context.ResourceEntities.Add(model);
        _context.SaveChanges();
    }
    void IResourceRepository.Delete(DeleteResourceCommad request)
    {
        _context.Remove(_context.ResourceEntities.AsNoTracking().FirstOrDefault(x => x.Id == request.Id));
        _context.SaveChanges();
    }

    ResourceGetQueryResultDto IResourceRepository.Get(Guid id)
    {
        var model = _context.ResourceEntities.AsNoTracking().FirstOrDefault(x => x.Id == id);
        if (model == null) throw new Exception("ingen resouce fundet");
        return new ResourceGetQueryResultDto
        {
            Id = model.Id,
            Description = model.Description,
            Specification = model.Specification,
            Price = model.Price
        };
    }

    IEnumerable<ResourceGetAllQueryResultDto> IResourceRepository.GetAll()
    {
        foreach(var model in _context.ResourceEntities.AsNoTracking().ToList())
        {
            yield return new ResourceGetAllQueryResultDto
            {
                Id = model.Id,
                Description = model.Description,
                Specification = model.Specification,
                Price = model.Price
            };
        }
    }
}
