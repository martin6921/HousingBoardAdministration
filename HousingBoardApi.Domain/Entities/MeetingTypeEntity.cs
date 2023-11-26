namespace HousingBoardApi.Domain.Entities;

public class MeetingTypeEntity : BaseEntity
{
    public string Type { get; set; }
    public ICollection<MeetingEntity> Meetings { get; set; }

}