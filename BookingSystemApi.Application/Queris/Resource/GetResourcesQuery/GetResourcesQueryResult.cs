using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Resource.GetResourcesQuery
{
    public class GetResourcesQueryResult
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal Price { get; set; }
        //public List<BookingEntity>? Bookings { get; set; }


    }
}
