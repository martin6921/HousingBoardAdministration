using BookingSystemApi.Application.IRepositories;

namespace BookingSystemApi.Application.Queris.Booking.GetAllBooking
{
    public class GetAllBookingsQueryHandler : IRequestHandler<GetAllBookingsQuery, List<GetAllBookingsQueryResult>>
    {

        private readonly IBookingRepository _bookingRepository;

        public GetAllBookingsQueryHandler(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        Task<List<GetAllBookingsQueryResult>> IRequestHandler<GetAllBookingsQuery, List<GetAllBookingsQueryResult>>.Handle(GetAllBookingsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_bookingRepository.GetAll(request).ToList());
        } 
    }
}
