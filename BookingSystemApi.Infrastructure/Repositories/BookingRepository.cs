using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        void IBookingRepository.Create(CreateBookingCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
