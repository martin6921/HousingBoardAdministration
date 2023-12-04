using BookingSystemApi.Application.Commands.Resource.Create;
using BookingSystemApi.Application.IRepositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HousingBoardAdministration.BookingSystemApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RessourceController : ControllerBase
    {
        private readonly IMediator _mediator;


        public RessourceController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public ActionResult Post([FromBody]CreateResourceCommand request)
        {
            try
            {
                _mediator.Send(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

