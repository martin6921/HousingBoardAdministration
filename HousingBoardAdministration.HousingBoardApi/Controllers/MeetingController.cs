using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.Commands.Meeting.Delete;
using HousingBoardApi.Application.Commands.Meeting.Edit;
using HousingBoardApi.Application.Queries.Meeting.Dto;
using HousingBoardApi.Application.Queries.Meeting.Interface;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingBoardAdministration.HousingBoardApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingGetAllQuery _meetingGetAllQuery;
        private readonly IMeetingGetQuery _meetingGetQuery;
        private readonly IMediator _mediator;

        public MeetingController(IMediator mediator, IMeetingGetQuery meetingGetQuery, IMeetingGetAllQuery meetingGetAllQuery)
        {
            _mediator = mediator;
            _meetingGetQuery = meetingGetQuery;
            _meetingGetAllQuery = meetingGetAllQuery;
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] DeleteMeetingCommand request)
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

        [HttpPost]
        public ActionResult Post([FromBody]CreateMeetingCommand request)
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
        public ActionResult Put([FromBody]EditMeetingCommand request)
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

        [HttpGet]
        public ActionResult<IEnumerable<MeetingGetAllQueryResultDto>> GetAll()
        {
            var result = _meetingGetAllQuery.GetAll();
            //if (!result.Any())
            // return NotFound();

            return result.ToList();
        }

        // GET api/<ResourceController>/5
        [HttpGet("{id}")]
        public ActionResult<MeetingGetQueryResultDto> Get(Guid id)
        {
            var result = _meetingGetQuery.Get(id);
            return result;
        }
    }
}
