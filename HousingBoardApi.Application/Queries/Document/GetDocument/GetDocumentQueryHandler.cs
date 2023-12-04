using HousingBoardApi.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Document.GetDocument
{
    public class GetDocumentQueryHandler : IRequestHandler<GetDocumentQuery, GetDocumentQueryResult>
    {
        private readonly IDocumentRepository _documentRepository;

        public GetDocumentQueryHandler(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        Task<GetDocumentQueryResult> IRequestHandler<GetDocumentQuery, GetDocumentQueryResult>.Handle(GetDocumentQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_documentRepository.Get(request));
        }
    }
}
