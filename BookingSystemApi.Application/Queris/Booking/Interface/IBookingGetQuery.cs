using BookingSystemApi.Application.Queris.Booking.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Booking.Interface
{
    public interface IBookingGetQuery
    {
        BookingGetQueryResultDto Get(Guid id);
    }
}
