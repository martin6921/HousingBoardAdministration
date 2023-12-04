using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Resident.GetResident
{
    public record GetResidentQuery : IRequest<GetResidentQueryResult>
    {
        public Guid Id { get; set; }

    }
}
