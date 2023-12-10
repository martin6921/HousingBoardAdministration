using HousingBoardApi.Application.IRepositories;
using HousingBoardApi.Application.Messages;
using HousingBoardApi.Application.Messages.Events;
using HousingBoardApi.Application.Queries.Meeting;
using HousingBoardApi.Domain.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Meeting.Create;

public class CreateMeetingCommandHandler : IRequestHandler<CreateMeetingCommand>
{
    private readonly IMeetingRepository _meetingRepository;
    private readonly IPublisher _publisher;
    public CreateMeetingCommandHandler(IMeetingRepository meetingRepository, IPublisher publisher)
    {
        _meetingRepository = meetingRepository;
        _publisher = publisher;
    }

    public Task Handle(CreateMeetingCommand request, CancellationToken cancellationToken)
    {
        _meetingRepository.Add(request);

        //Send email
        //_publisher.Publish(new CreateMeetingEmailEvent
        //{
        //    Title = request.Title,
        //    MeetingTime = request.MeetingTime,
        //    AddressLocation = request.AddressLocation,
        //});

        return Task.CompletedTask;
    }
}
