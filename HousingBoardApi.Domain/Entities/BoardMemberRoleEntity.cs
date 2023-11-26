namespace HousingBoardApi.Domain.Entities;

public class BoardMemberRoleEntity : BaseEntity
{
    public RoleEntity Role { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public BoardMemberEntity BoardMember { get; set; }
}
