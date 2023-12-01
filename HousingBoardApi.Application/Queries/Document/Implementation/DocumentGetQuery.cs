using HousingBoardApi.Application.IRepositories;
using HousingBoardApi.Application.Queries.Document.Dto;
using HousingBoardApi.Application.Queries.Document.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.Queries.Document.Implementation
{
    public class DocumentGetQuery : IDocumentGetQuery
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentGetQuery(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        DocumentGetQueryResultDto IDocumentGetQuery.Get(Guid id)
        {
            return _documentRepository.Get(id);
        }
    }
}
