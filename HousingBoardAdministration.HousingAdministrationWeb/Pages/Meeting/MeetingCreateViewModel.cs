namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting;

public record MeetingCreateViewModel
{
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime MeetingTime { get; set; }
    public string AddressLocation { get; set; }

    public Guid MeetingTypeId { get; set; }
    public Guid MeetingOwnerId { get; set; }
}
