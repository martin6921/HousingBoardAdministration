using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Document.Edit
{
    public record EditDocumentCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid DocumentTypeId { get; set; }
        public required byte[] DocumentFile { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
