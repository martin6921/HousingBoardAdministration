using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Meeting;

public record MeetingTypeDto
{
    public Guid Id { get; set; }
    public string Type { get; set; }
}
