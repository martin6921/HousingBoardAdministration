using HousingBoardApi.Application.Queries.Document.Dto;
using HousingBoardApi.Application.Queries.Meeting.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Document.Interface
{
    public interface IDocumentGetAllQuery
    {
        IEnumerable<DocumentGetAllQueryResultDto> GetAll();
    }
}
