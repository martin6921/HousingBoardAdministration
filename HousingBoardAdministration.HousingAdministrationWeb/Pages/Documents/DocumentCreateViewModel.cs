using System.ComponentModel.DataAnnotations;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Documents
{
    public record DocumentCreateViewModel
    {
        public string Title { get; set; }
        public Guid DocumentTypeId { get; set; }
        public required string DocumentFile { get; set; }
        public DateTime UploadDate { get; set; }
        [Required]
        public Guid MeetingId { get; set; }
        [Required]
        public Guid DocumentOwnerId { get; set; }
    }
}
