using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Document.GetDocument;

public record GetDocumentQuery : IRequest<GetDocumentQueryResult>
{
    public Guid Id { get; set; }

}
