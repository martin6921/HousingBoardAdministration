namespace HousingBoardApi.Domain.Entities;

public class DocumentEntity : BaseEntity
{
    public string Title { get; set; }
    public DocumentTypeEntity DocumentType { get; set; }
    public required byte[] DocumentFile { get; set; }
    public DateTime UploadDate { get; set; }
    public MeetingEntity Meeting { get; set; }
    public BoardMemberEntity DocumentOwner { get; set; }

}