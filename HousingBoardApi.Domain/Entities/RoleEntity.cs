namespace HousingBoardApi.Domain.Entities;

public class RoleEntity : BaseEntity
{
    public string RoleName { get; set; }

    public ICollection<BoardMemberRoleEntity> BoardMemberRoles { get; set; }
}
