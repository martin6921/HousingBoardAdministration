using BookingSystemApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Booking.GetBooking
{
    public class GetBookingQueryHandler : IRequestHandler<GetBookingQuery, GetBookingQueryResult>
    {
        private readonly IBookingRepository _bookingRepository;


        public GetBookingQueryHandler(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        Task<GetBookingQueryResult> IRequestHandler<GetBookingQuery, GetBookingQueryResult>.Handle(GetBookingQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_bookingRepository.Get(request));
        }
    }
}
