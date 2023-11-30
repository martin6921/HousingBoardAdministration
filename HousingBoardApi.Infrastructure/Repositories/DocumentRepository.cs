using HousingBoardApi.Application.Commands.Document.Create;
using HousingBoardApi.Application.Commands.Document.Delete;
using HousingBoardApi.Application.Queries.Document.Dto;
using HousingBoardApi.Application.Queries.Meeting.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Infrastructure.Repositories;

public class DocumentRepository : IDocumentRepository
{
    private readonly HousingBoardDbContext _dbContext;

    public DocumentRepository(HousingBoardDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    void IDocumentRepository.Add(CreateDocumentCommand request)
    {
        DocumentTypeEntity documentType = _dbContext.DocumentTypeEntities.FirstOrDefault(x => x.Id == request.DocumentTypeId);
        MeetingEntity meeting = _dbContext.MeetingEntities.FirstOrDefault(x => x.Id == request.MeetingId); 
        BoardMemberEntity documentOwner = _dbContext.BoardMemberEntities.FirstOrDefault(x => x.Id == request.DocumentOwnerId); 

        DocumentEntity newDocument = new DocumentEntity
        {
            Title = request.Title,
            DocumentType = documentType,
            DocumentFile = Convert.FromBase64String(request.DocumentFile),
            UploadDate = request.UploadDate,
            Meeting = meeting,
            DocumentOwner = documentOwner
        };


        _dbContext.Add(newDocument);
        _dbContext.SaveChanges();
    }

    void IDocumentRepository.Delete(DeleteDocumentCommand request)
    {
        throw new NotImplementedException();
    }

    DocumentGetQueryResultDto IDocumentRepository.Get(Guid id)
    {
        throw new NotImplementedException();
    }

    IEnumerable<DocumentGetAllQueryResultDto> IDocumentRepository.GetAll()
    {
        throw new NotImplementedException();
    }

    DocumentEntity IDocumentRepository.Load(Guid id)
    {
        throw new NotImplementedException();
    }

    void IDocumentRepository.Edit(DocumentEntity model)
    {
        throw new NotImplementedException();
    }
}
