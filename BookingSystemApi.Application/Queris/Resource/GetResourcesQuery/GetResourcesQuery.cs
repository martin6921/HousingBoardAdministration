using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Resource.GetResourcesQuery
{
    public class GetResourcesQuery : IRequest<GetResourcesQueryResult>
    {
        public Guid Id { get; set; }
    }
}
