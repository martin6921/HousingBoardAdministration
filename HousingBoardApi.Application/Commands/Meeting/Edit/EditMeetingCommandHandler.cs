using HousingBoardApi.Application.IRepositories;
using System;


namespace HousingBoardApi.Application.Commands.Meeting.Edit;

public class EditMeetingCommandHandler : IRequestHandler<EditMeetingCommand>
{
    private readonly IMeetingRepository _meetingRepository;

    public EditMeetingCommandHandler(IMeetingRepository meetingRepository)
    {
        _meetingRepository = meetingRepository;
    }

    Task IRequestHandler<EditMeetingCommand>.Handle(EditMeetingCommand request, CancellationToken cancellationToken)
    {

        //Read
        var model = _meetingRepository.Load(request.Id);

        //DoIt
        model.Edit(request.Title, request.Description, request.MeetingTime, request.AddressLocation, request.RowVersion);

        //Save
        _meetingRepository.Update(model);

        return Task.CompletedTask;

    }
}
