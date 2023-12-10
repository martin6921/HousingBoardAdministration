using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.IRepositories;
using HousingBoardApi.Application.Messages.Events;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Test.Meeting.Commands
{
    public class CreateMeetingCommandHandlerTests
    {
        private readonly Mock<IMeetingRepository> _meetingRepositoryMock;

        private readonly Mock<IPublisher> _publisherMock;

        public CreateMeetingCommandHandlerTests()
        {
            _meetingRepositoryMock = new();
            _publisherMock = new();
        }

        [Fact]
        public async Task Handler_Should_Succes_When_values_Is_valid()
        {
            //arrange
            var command = new CreateMeetingCommand
            {
                MeetingOwnerId = Guid.NewGuid(),
                MeetingTypeId = Guid.NewGuid(),
                AddressLocation = "Adreese",
                Description = "Description",
                MeetingTime = DateTime.Now,
                Title = "Title"
            };
            var handler = new CreateMeetingCommandHandler(_meetingRepositoryMock.Object, _publisherMock.Object);

            //act
            await handler.Handle(command, default);
            //Assert
            _meetingRepositoryMock.Verify(repo => repo.Add(It.IsAny<CreateMeetingCommand>()), Times.Once);

        }

    }
}
