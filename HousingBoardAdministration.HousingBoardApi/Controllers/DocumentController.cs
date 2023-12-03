using HousingBoardApi.Application.Commands.Document.Create;
using HousingBoardApi.Application.Commands.Document.Delete;
using HousingBoardApi.Application.Commands.Document.Edit;
using HousingBoardApi.Application.Queries.Document.Dto;
using HousingBoardApi.Application.Queries.Document.Interface;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HousingBoardAdministration.HousingBoardApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DocumentController : ControllerBase
{
    private readonly IDocumentGetAllQuery _documentGetAllQuery;
    private readonly IDocumentGetQuery _documentGetQuery;
    private readonly IMediator _mediator;

    public DocumentController(IDocumentGetAllQuery documentGetAllQuery, IDocumentGetQuery documentGetQuery, IMediator mediator)
    {
        _documentGetAllQuery = documentGetAllQuery;
        _documentGetQuery = documentGetQuery;
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public ActionResult<DocumentGetQueryResultDto> Get(Guid id)
    {
        var result = _documentGetQuery.Get(id);
        return result;
    }

    [HttpGet]
    public ActionResult<IEnumerable<DocumentGetAllQueryResultDto>> GetAll()
    {
        var result = _documentGetAllQuery.GetAll();
        return result.ToList();
    }

    [HttpPost]
    public ActionResult Post([FromBody] CreateDocumentCommand request)
    {
        try
        {
            _mediator.Send(request);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut]
    public ActionResult Put([FromBody] EditDocumentCommand request)
    {
        try
        {
            _mediator.Send(request);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete]
    public ActionResult Delete([FromBody] DeleteDocumentCommand request)
    {
        try
        {
            _mediator.Send(request);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}
