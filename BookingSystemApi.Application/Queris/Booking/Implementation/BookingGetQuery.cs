using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Booking.Dto;
using BookingSystemApi.Application.Queris.Booking.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Booking.Implementation
{
    public class BookingGetQuery : IBookingGetQuery
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingGetQuery(IBookingRepository meetingRepository)
        {
            _bookingRepository = meetingRepository;
        }
        BookingGetQueryResultDto IBookingGetQuery.Get(Guid id)
        {
            return _bookingRepository.Get(id);
        }
    }
}
