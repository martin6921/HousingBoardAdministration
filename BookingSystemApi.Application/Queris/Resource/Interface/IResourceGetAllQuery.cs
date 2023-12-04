using BookingSystemApi.Application.Queris.Resource.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Queris.Resource.Interface
{
    public interface IResourceGetAllQuery
    {
        IEnumerable<ResourceGetAllQueryResultDto> GetAll();
    }
}
