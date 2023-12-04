using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Commands.Resident.Delete
{
    public record DeleteResidentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
