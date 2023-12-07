﻿namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document;

public record DocumentCreateViewModel
{
    public string Title { get; set; }
    public Guid DocumentTypeId { get; set; }
    public required string DocumentFile { get; set; }
    public Guid MeetingId { get; set; }
    public Guid DocumentOwnerId { get; set; }
}
