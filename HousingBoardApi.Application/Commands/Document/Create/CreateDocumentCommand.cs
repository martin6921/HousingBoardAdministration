using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Document.Create;

public record CreateDocumentCommand : IRequest
{
    public string Title { get; set; }
    public Guid DocumentTypeId { get; set; }
    public required string DocumentFile { get; set; } //has to be string as byte[] is not supported
    public DateTime UploadDate { get; set; }
    [Required]
    public Guid MeetingId { get; set; }
    [Required]
    public Guid DocumentOwnerId { get; set; }
}
