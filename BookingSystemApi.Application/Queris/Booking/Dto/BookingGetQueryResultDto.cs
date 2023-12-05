using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Booking.Dto
{
    public class BookingGetQueryResultDto
    {
        public Guid Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
