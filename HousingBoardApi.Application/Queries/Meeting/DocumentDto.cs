using HousingBoardApi.Application.Queries.Document.GetDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Meeting
{
    public class DocumentDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DocumentTypeDto DocumentType { get; set; }
        public byte[] DocumentFile { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
