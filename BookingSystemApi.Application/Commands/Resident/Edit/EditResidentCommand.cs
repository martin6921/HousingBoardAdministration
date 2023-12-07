using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Commands.Resident.Edit
{
    public record EditResidentCommand : IRequest
    {
        public Guid Id { get; set; }

       
        
        public bool IsDeleted { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ResidentAddress { get; set; }

    }
}
