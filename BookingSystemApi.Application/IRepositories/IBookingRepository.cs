using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.Commands.Booking.Delete;
using BookingSystemApi.Application.Commands.Booking.Update;
using BookingSystemApi.Application.Queris.Booking.Dto;
using BookingSystemApi.Domain.Entities;

namespace BookingSystemApi.Application.IRepositories
{
    public interface IBookingRepository
    {
        BookingEntity Load(Guid id);
        void Create(CreateBookingCommand request);
        BookingGetQueryResultDto Get(Guid id);
        IEnumerable<BookingGetAllQueryResultDto> Getall();
        void Delete(DeleteBookingCommand request);
        void Edit(BookingEntity request);
    }
}


