using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Document.Dto
{
    public class DocumentGetQueryResultDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid DocumentTypeId { get; set; }
        public required byte[] DocumentFile { get; set; }
        public DateTime UploadDate { get; set; }
        [Required]
        public Guid MeetingId { get; set; }
        [Required]
        public Guid DocumentOwnerId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
