using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Meeting.Create;

public class CreateMeetingCommandHandler : IRequestHandler<CreateMeetingCommand>
{
    private readonly IMeetingRepository _meetingRepository;

    public CreateMeetingCommandHandler(IMeetingRepository meetingRepository)
    {
        _meetingRepository = meetingRepository;
    }

    Task IRequestHandler<CreateMeetingCommand>.Handle(CreateMeetingCommand request, CancellationToken cancellationToken)
    {
        _meetingRepository.Add(request);
        return Task.CompletedTask;

    }
}
