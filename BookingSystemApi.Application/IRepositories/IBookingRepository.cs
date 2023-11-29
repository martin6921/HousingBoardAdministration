using BookingSystemApi.Application.Commands.Booking.Create;


namespace BookingSystemApi.Application.IRepositories
{
    public interface IBookingRepository
    {
        void Create(CreateBookingCommand request);
    }

}
