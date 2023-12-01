using HousingBoardApi.Application.Commands.Document.Create;
using HousingBoardApi.Application.Commands.Document.Delete;
using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.Commands.Meeting.Delete;
using HousingBoardApi.Application.Queries.Document.Dto;
using HousingBoardApi.Application.Queries.Meeting.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.IRepositories;

public interface IDocumentRepository
{
    void Add(CreateDocumentCommand request);
    DocumentEntity Load(Guid id);
    IEnumerable<DocumentGetAllQueryResultDto> GetAll();
    void Edit(DocumentEntity model);

    DocumentGetQueryResultDto Get(Guid id);
    void Delete(DeleteDocumentCommand request);
}
