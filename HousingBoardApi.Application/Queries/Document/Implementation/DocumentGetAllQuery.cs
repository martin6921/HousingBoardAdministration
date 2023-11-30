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
    public class DocumentGetAllQuery : IDocumentGetAllQuery
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentGetAllQuery(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        IEnumerable<DocumentGetAllQueryResultDto> IDocumentGetAllQuery.GetAll()
        {
            return _documentRepository.GetAll();
        }
    }
}
