using BookingSystemApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemApi.Application.Commands.Resource.Delete
{
    public class DeleteResourceCommandHandler : IRequestHandler<DeleteResourceCommad>
    {
        private readonly IResourceRepository _resourceRepository;

        public DeleteResourceCommandHandler(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }
        Task IRequestHandler<DeleteResourceCommad>.Handle(DeleteResourceCommad request, CancellationToken cancellationToken)
        {
            _resourceRepository.Delete(request);
            return Task.CompletedTask;
        }
    }
}
