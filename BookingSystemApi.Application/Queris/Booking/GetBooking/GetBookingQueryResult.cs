using BookingSystemApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Booking.GetBooking
{
    public class GetBookingQueryResult
    {
        public Guid Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<ResourceDto> Resources { get; set; }
    }
}
