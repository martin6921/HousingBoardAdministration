using HousingBoardApi.Application.IRepositories;
using HousingBoardApi.Application.Messages;
using HousingBoardApi.Application.Messages.Events;
using HousingBoardApi.Domain.Mail;
using MediatR;
using System;


namespace HousingBoardApi.Application.Commands.Meeting.Edit;

public class EditMeetingCommandHandler : IRequestHandler<EditMeetingCommand>
{
    private readonly IMeetingRepository _meetingRepository;
    private readonly IPublisher _publisher;

    public EditMeetingCommandHandler(IMeetingRepository meetingRepository, IPublisher publisher)
    {
        _meetingRepository = meetingRepository;
        _publisher = publisher;
    }

    Task IRequestHandler<EditMeetingCommand>.Handle(EditMeetingCommand request, CancellationToken cancellationToken)
    {

        //Read
        var model = _meetingRepository.Load(request.Id);

        //DoIt
        model.Edit(request.Title, request.Description, request.MeetingTime, request.AddressLocation, request.RowVersion);

        //Save
        _meetingRepository.Update(model);

        //Send email
        _publisher.Publish(new CreateMeetingEmailEvent
        {
            Title = request.Title,
            MeetingTime = request.MeetingTime,
            AddressLocation = request.AddressLocation,
        });


        return Task.CompletedTask;

    }
}
