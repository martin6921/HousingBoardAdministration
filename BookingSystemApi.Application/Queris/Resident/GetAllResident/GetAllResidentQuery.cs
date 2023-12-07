using BookingSystemApi.Application.Queris.Resident.GetResident;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Resident.GetAllResident
{
    public record GetAllResidentQuery : IRequest<List<GetAllResidentQueryResult>>
    {
        public Guid Id { get; set; }
    }
}
