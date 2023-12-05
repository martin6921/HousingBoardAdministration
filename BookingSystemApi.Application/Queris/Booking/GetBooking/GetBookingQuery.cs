using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Booking.GetBooking
{
    public class GetBookingQuery : IRequest<GetBookingQueryResult>
    {
        public Guid Id { get; set; }
    }
}
