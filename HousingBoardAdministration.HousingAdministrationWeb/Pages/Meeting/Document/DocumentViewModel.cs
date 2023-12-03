namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document;

public record DocumentViewModel
{
    public string Title { get; set; }
    public DocumentTypeViewModel DocumentType { get; set; }
    public required string DocumentFile { get; set; }
    public DateTime UploadDate { get; set; }
    //public Guid DocumentOwnerId { get; set; }
}
