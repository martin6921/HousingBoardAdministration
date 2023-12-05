using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.Commands.Booking.Delete;
using BookingSystemApi.Application.Commands.Booking.Update;
using BookingSystemApi.Application.Queris.Booking.GetAllBooking;
using BookingSystemApi.Application.Queris.Booking.GetBooking;
using BookingSystemApi.Domain.Entities;

namespace BookingSystemApi.Application.IRepositories
{
    public interface IBookingRepository
    {
        BookingEntity Load(Guid id);
        void Create(CreateBookingCommand request); 
        void Delete(DeleteBookingCommand request);
        void Edit(BookingEntity request);
        GetBookingQueryResult Get(GetBookingQuery request);
        IEnumerable<GetAllBookingsQueryResult> GetAll(GetAllBookingsQuery request);
    }
}


