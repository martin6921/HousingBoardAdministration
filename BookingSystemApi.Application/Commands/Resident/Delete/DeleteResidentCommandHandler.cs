using BookingSystemApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Commands.Resident.Delete
{
    public class DeleteResidentCommandHandler : IRequestHandler<DeleteResidentCommand>
    {
        private readonly IResidentRepository _residentRepository;
        public DeleteResidentCommandHandler(IResidentRepository residentRepository)
        { 
         _residentRepository = residentRepository;
        }
        public Task Handle(DeleteResidentCommand request, CancellationToken cancellationToken)
        {
            _residentRepository.Delete(request);
            return Task.CompletedTask;
        }
    }
}
