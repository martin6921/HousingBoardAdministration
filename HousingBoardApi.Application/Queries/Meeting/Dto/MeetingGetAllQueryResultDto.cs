using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Meeting.Dto
{
    public class MeetingGetAllQueryResultDto
    {
        public Guid Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public MeetingTypeEntity MeetingType { get; set; }


        public DateTime MeetingTime { get; set; }
        public string AddressLocation { get; set; }
    }
}
