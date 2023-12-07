using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Booking.Dto
{
    public class ResourceDto
    {
        public Guid Id {  get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal Price { get; set; }
    }
}
