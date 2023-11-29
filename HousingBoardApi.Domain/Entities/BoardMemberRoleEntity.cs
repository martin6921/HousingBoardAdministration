using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HousingBoardApi.Domain.Entities;

public class BoardMemberRoleEntity
{
    public BoardMemberRoleEntity() { }

    public Guid RoleId { get; set; }

    public RoleEntity Role { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    [Timestamp]
    public byte[] RowVersion { get; set; }

    public Guid BoardMemberId { get; set; }
    public BoardMemberEntity BoardMember { get; set; }
}
