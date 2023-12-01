using HousingBoardApi.Application.Commands.Document.Create;
using HousingBoardApi.Application.Commands.Document.Delete;
using HousingBoardApi.Application.Queries.Document.Dto;

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
        DocumentTypeEntity documentType = new DocumentTypeEntity { Id = request.DocumentTypeId };
        MeetingEntity meeting = new MeetingEntity { Id = request.MeetingId };
        BoardMemberEntity documentOwner = new BoardMemberEntity { Id = request.DocumentOwnerId };

        _dbContext.Attach(documentType);
        _dbContext.Attach(meeting);
        _dbContext.Attach(documentOwner); 

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
        _dbContext.Remove(_dbContext.DocumentEntities.AsNoTracking().FirstOrDefault(x => x.Id == request.Id));
        _dbContext.SaveChanges();
    }

    DocumentGetQueryResultDto IDocumentRepository.Get(Guid id)
    {
        //var model = _db.MeetingEntities.AsNoTracking().IgnoreQueryFilters().FirstOrDefault(x => x.Id == id);
        var model = _dbContext.DocumentEntities
            .Include(type => type.DocumentType)
            .Include(meeting => meeting.Meeting)
            .Include(owner => owner.DocumentOwner)

            .AsNoTracking().FirstOrDefault(x => x.Id == id);


        if (model == null) throw new Exception("No document found");

        return new DocumentGetQueryResultDto
        {
            Id = model.Id,
            Title = model.Title,
            DocumentTypeId = model.DocumentType.Id,
            DocumentFile = model.DocumentFile,
            MeetingId = model.Meeting.Id,
            DocumentOwnerId = model.DocumentOwner.Id,
            UploadDate = model.UploadDate,
            RowVersion = model.RowVersion
        };
    }

    IEnumerable<DocumentGetAllQueryResultDto> IDocumentRepository.GetAll()
    {
        foreach (DocumentEntity document in _dbContext.DocumentEntities
            .Include(type => type.DocumentType)
            .Include(meeting => meeting.Meeting)
            .Include (owner => owner.DocumentOwner)
            
            .AsNoTracking()
            .ToList())
        {
            document.UploadDate = DateTime.Now;
            yield return new DocumentGetAllQueryResultDto
            {
                Id = document.Id,
                Title = document.Title,
                DocumentTypeId = document.DocumentType.Id,
                DocumentFile = document.DocumentFile,
                MeetingId = document.Meeting.Id,
                DocumentOwnerId = document.DocumentOwner.Id,
                UploadDate = document.UploadDate,
                RowVersion = document.RowVersion,
            };
        }
    }

    DocumentEntity IDocumentRepository.Load(Guid id)
    {
        DocumentEntity model = _dbContext.DocumentEntities.FirstOrDefault(x => x.Id == id);

        return model == null ? throw new Exception("No document found") : model;
    }

    void IDocumentRepository.Edit(DocumentEntity model)
    {
        _dbContext.Update(model);
        _dbContext.SaveChanges();
    }
}
