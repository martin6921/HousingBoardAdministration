using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Booking.Interface;
using BookingSystemApi.Application.Queris.Booking.Dto;


namespace BookingSystemApi.Application.Queris.Booking.Implementation
{
    public class BookingGetAllQuery : IBookingGetAllQuery
    {

        private readonly IBookingRepository _bookingRepository;

        public BookingGetAllQuery(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        IEnumerable<BookingGetAllQueryResultDto> IBookingGetAllQuery.GetAll()
        {
            return _bookingRepository.GetAll();
        }
    }
}
