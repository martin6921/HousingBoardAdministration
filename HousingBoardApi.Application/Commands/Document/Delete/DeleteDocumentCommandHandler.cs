using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Document.Delete
{
    public class DeleteDocumentCommandHandler : IRequestHandler<DeleteDocumentCommand>
    {
        private readonly IDocumentRepository _documentRepository;

        public DeleteDocumentCommandHandler(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        Task IRequestHandler<DeleteDocumentCommand>.Handle(DeleteDocumentCommand request, CancellationToken cancellationToken)
        {
            _documentRepository.Delete(request);
            return Task.CompletedTask;
        }
    }
}
