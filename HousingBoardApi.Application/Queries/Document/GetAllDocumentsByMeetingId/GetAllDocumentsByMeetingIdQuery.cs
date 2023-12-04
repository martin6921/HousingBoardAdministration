using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Document.GetAllDocuments;

public record GetAllDocumentsByMeetingIdQuery : IRequest<List<GetAllDocumentsByMeetingIdQueryResult>>
{
    public Guid MeetingId { get; set; }
}
