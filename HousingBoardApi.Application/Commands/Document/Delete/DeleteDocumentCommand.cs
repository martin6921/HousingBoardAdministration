using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Document.Delete
{
    public record DeleteDocumentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
