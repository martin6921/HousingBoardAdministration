using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Meeting.Delete;

public class DeleteMeetingCommandHandler : IRequestHandler<DeleteMeetingCommand>
{
    private readonly IMeetingRepository _meetingRepository;

    public DeleteMeetingCommandHandler(IMeetingRepository meetingRepository)
    {
        _meetingRepository = meetingRepository;
    }

    Task IRequestHandler<DeleteMeetingCommand>.Handle(DeleteMeetingCommand request, CancellationToken cancellationToken)
    {
        _meetingRepository.Delete(request);
        return Task.CompletedTask;
        
    }
}
