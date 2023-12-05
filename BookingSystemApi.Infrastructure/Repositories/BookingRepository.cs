using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.Commands.Booking.Delete;
using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Booking.GetAllBooking;
using BookingSystemApi.Application.Queris.Booking.GetBooking;
using BookingSystemApi.Domain.Entities;
using BookingSystemApi.SqlServerContext;
using Microsoft.EntityFrameworkCore;


namespace BookingSystemApi.Infrastructure.Repositories;

public class BookingRepository : IBookingRepository
{
    private readonly BookingSystemDbContext _db;

    public BookingRepository(BookingSystemDbContext db) 
    {
        _db = db;
    }

    void IBookingRepository.Delete(DeleteBookingCommand request)
    {
        _db.Remove(_db.BookingEntities.AsNoTracking().FirstOrDefault(x => x.Id == request.Id));
        _db.SaveChanges();
    }

     void IBookingRepository.Edit(BookingEntity model)
    {
        _db.Update(model);
        _db.SaveChanges();

    }

    //public GetBookingQueryResult Get(Guid id)
    //{
    //    var model = _db.BookingEntities.AsNoTracking().FirstOrDefault(x => x.Id == id);


    //    if (model == null) throw new Exception("Ingen meeting fundet i databasen");

    //    return new GetBookingQueryResult
    //    {
    //        Id = model.Id,
    //        RowVersion = model.RowVersion,
    //        StartDate = model.StartDate,
    //        EndDate = model.EndDate
    //    };
    //}

     BookingEntity IBookingRepository.Load(Guid id)
    {
        var model = _db.BookingEntities.FirstOrDefault(x => x.Id == id);
        return model == null ? throw new Exception("Ingen Booking fundet i databasen") : model;
    }

    void IBookingRepository.Create(CreateBookingCommand request)
    {
        //var resident = _db.ResidentEntities.FirstOrDefault(x => x.Id == request.Id);
        //var resource = _db.ResourceEntities.FirstOrDefault(x => x.Id == request.Id);

        ResidentEntity resident = new ResidentEntity { Id = request.BookingOwnerId };
        List<ResourceEntity> resourceList = request.ResourceIdsList.Select(id => new ResourceEntity { Id = id }).ToList();

        _db.Attach(resident);
        foreach (ResourceEntity resource in resourceList ) 
        {
            _db.Attach(resource);
        }
        BookingEntity model = new BookingEntity
        {
            
            IsDeleted = false,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
            BookingOwner = resident,
            Resources = resourceList

        };

        _db.Add(model);
        _db.SaveChanges();
    }

    //IEnumerable<GetAllBookingsQueryResult> IBookingRepository.GetAll()
    //{
    //    foreach (var model in _db.BookingEntities.AsNoTracking().ToList())
    //    {
    //        yield return new GetAllBookingsQueryResult
    //        {
    //            Id = model.Id,
    //            StartDate = model.StartDate,
    //            EndDate = model.EndDate
    //        };
    //    }
    //}

    GetBookingQueryResult IBookingRepository.Get(GetBookingQuery request)
    {
        var model = _db.BookingEntities.AsNoTracking().FirstOrDefault(x => x.Id == request.Id);
        if (model == null) throw new Exception("Ingen meeting fundet i databasen");
        return new GetBookingQueryResult
        {
            Id = model.Id,
            RowVersion = model.RowVersion,
            StartDate = model.StartDate,
            EndDate = model.EndDate
        };
    }

    IEnumerable<GetAllBookingsQueryResult> IBookingRepository.GetAll(GetAllBookingsQuery request)
    {
        foreach (var model in _db.BookingEntities.AsNoTracking().ToList())
        {
            yield return new GetAllBookingsQueryResult
            {
                Id = model.Id,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };
        }
    }
}
