using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.Commands.Booking.Delete;
using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Booking.Dto;
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

    public BookingGetQueryResultDto Get(Guid id)
    {
        var model = _db.BookingEntities.AsNoTracking().FirstOrDefault(x => x.Id == id);


        if (model == null) throw new Exception("Ingen meeting fundet i databasen");

        return new BookingGetQueryResultDto
        {
            Id = model.Id,
            RowVersion = model.RowVersion,
            IsDeleted = model.IsDeleted,
            StartDate = model.StartDate,
            EndDate = model.EndDate
        };
    }

    public IEnumerable<BookingGetAllQueryResultDto> Getall()
    {
        foreach (var model in _db.BookingEntities.AsNoTracking().ToList())
        {
            yield return new BookingGetAllQueryResultDto
            {
                Id = model.Id,
                RowVersion = model.RowVersion,
                IsDeleted = model.IsDeleted,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };
        }
    }

     BookingEntity IBookingRepository.Load(Guid id)
    {
        var model = _db.BookingEntities.FirstOrDefault(x => x.Id == id);
        return model == null ? throw new Exception("Ingen Booking fundet i databasen") : model;
    }

    void IBookingRepository.Create(CreateBookingCommand request)
    {
        var booking = _db.BookingEntities.FirstOrDefault(x => x.Id == request.Id);
        var resource = _db.ResourceEntities.FirstOrDefault(x => x.Id == request.Id);

        var model = new BookingEntity
        {
            Id = request.Id,
            IsDeleted = false,
            StartDate = request.StartDate,
            EndDate = request.EndDate

        };

        _db.Add(model);
        _db.SaveChanges();
    }
}
