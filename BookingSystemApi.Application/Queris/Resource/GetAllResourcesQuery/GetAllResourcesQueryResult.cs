using BookingSystemApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Resource.GetAllResourcesQuery
{
    public class GetAllResourcesQueryResult
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal Price { get; set; }
        //public List<BookingEntity>? Bookings { get; set; }
    }
}
