namespace HousingBoardApi.Domain.Entities;

public class MeetingEntity
{
    public MeetingEntity()
    {

    }


    public string Title { get; set; }
    public string Description { get; set; }
    public MeetingTypeEntity MeetingType { get; set; }
    public DateTime MeetingTime { get; set; }
    public List<DocumentEntity>? Documents { get; set; }
    public BoardMemberEntity MeetingOwner { get; set; }
    public string AddressLocation { get; set; }
    public DateTime CreatedMeetingDate { get; set; }

}
