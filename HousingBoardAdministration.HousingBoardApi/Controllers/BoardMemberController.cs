using HousingBoardApi.Application.Commands.BoardMember.Create;
using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.IRepositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingBoardAdministration.HousingBoardApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BoardMemberController : ControllerBase
{
    private readonly IMediator _mediator;

    public BoardMemberController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public ActionResult Post([FromBody]CreateBoardMemberCommand request)
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
