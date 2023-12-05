using Microsoft.AspNetCore.Mvc;
using MediatR;
using BookingSystemApi.Application.Commands.Booking.Delete;
using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.Commands.Booking.Update;
using BookingSystemApi.Application.Queris.Booking.GetBooking;
using BookingSystemApi.Application.Queris.Booking.GetAllBooking;

namespace HousingBoardAdministration.BookingSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        //private readonly IBookingGetQuery _bookingGetQuery;
        //private readonly GetAllBookingsQuery _bookingGetAllQuery;
        private readonly IMediator _mediator;
        public BookingController(/*IBookingGetQuery bookingGetQuery, GetAllBookingsQuery bookingGetAllQuery,*/ IMediator mediator)
        {
            //_bookingGetQuery = bookingGetQuery;
            //_bookingGetAllQuery = bookingGetAllQuery;
            _mediator = mediator;
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] DeleteBookingCommand request)
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
        public ActionResult Post([FromBody] CreateBookingCommand request)
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
        public ActionResult Put([FromBody] EditBookingCommand request)
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
        public async Task<ActionResult<IEnumerable<GetAllBookingsQueryResult>>> GetAll()
        {
            var result = await _mediator.Send(new  GetAllBookingsQuery());
            return result.ToList();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetBookingQueryResult>> Get(Guid id) 
        { 
         var result = await _mediator.Send(new GetBookingQuery { Id = id });
            return result;
        }

    }
}
