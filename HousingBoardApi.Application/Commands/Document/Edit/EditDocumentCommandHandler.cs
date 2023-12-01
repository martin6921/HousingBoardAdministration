using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Document.Edit
{
    public class EditDocumentCommandHandler : IRequestHandler<EditDocumentCommand>
    {
        private readonly IDocumentRepository _DocumentRepository;

        public EditDocumentCommandHandler(IDocumentRepository documentRepository)
        {
            _DocumentRepository = documentRepository;
        }

        Task IRequestHandler<EditDocumentCommand>.Handle(EditDocumentCommand request, CancellationToken cancellationToken)
        {
        //load
        DocumentEntity document = _DocumentRepository.Load(request.Id);

        //edit
        document.Edit(request.Title, request.RowVersion);

        //Save
        _DocumentRepository.Edit(document);

        return Task.CompletedTask;
        }
    }
}
