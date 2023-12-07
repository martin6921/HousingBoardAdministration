using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Commands.Resource.Delete
{
    public class DeleteResourceCommad : IRequest
    {
        public Guid Id { get; set; }
    }
}
