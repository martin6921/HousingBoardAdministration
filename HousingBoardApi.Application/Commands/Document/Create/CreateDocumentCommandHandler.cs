using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Commands.Document.Create;

public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommand>
{
    private readonly IDocumentRepository _documentRepository;

    public CreateDocumentCommandHandler(IDocumentRepository documentRepository)
    {
        _documentRepository = documentRepository;
    }

    Task IRequestHandler<CreateDocumentCommand>.Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
    {
        _documentRepository.Add(request);
        return Task.CompletedTask;
    }
}
