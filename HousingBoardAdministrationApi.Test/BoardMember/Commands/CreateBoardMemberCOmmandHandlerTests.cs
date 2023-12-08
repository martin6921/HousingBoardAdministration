

using HousingBoardApi.Application.Commands.BoardMember.Create;
using HousingBoardApi.Application.IRepositories;
using Moq;

namespace HousingBoardApi.Test.BoardMember.Commands;

public class CreateBoardMemberCOmmandHandlerTests
{
    private readonly Mock<IBoardMemberRepository> _boardMemberRepositoryMock;
    private readonly Mock<IBoardMemberRoleRepository> _boardMemberRoleRepositoryMock;

    public CreateBoardMemberCOmmandHandlerTests(Mock<IBoardMemberRepository> boardMemberRepositoryMock, Mock<IBoardMemberRoleRepository> boardMemberRoleRepositoryMock)
    {
        _boardMemberRepositoryMock = new();
        _boardMemberRoleRepositoryMock = new();
    }

    [Fact]
    public async Task Handle_Should_Call()
    {
        // Arrange
        var commmand = new CreateBoardMemberCommand
        {
            FirstName = "Fornavn",
            LastName = "Efternavn",
            ResidentAddress = "Adresse",
            UserName = "mail@mail.dk",
            RoleId = Guid.NewGuid(),
            UserId = Guid.NewGuid()
        };

        var handler = new CreateBoardMemberCommandHandler(_boardMemberRepositoryMock.Object, _boardMemberRoleRepositoryMock.Object);

        // Act
        var result = handler.Handle(commmand, default);

        // Assert

    }
}
