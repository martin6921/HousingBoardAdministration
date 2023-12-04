using HousingBoardApi.Application.Queries.DocumentType.GetAllDocumentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingBoardApi.Application.IRepositories;

public interface IDocumentTypeRepository
{
    IEnumerable<GetAllDocumentTypesQueryResult> GetAll(GetAllDocumentTypesQuery request);
}
