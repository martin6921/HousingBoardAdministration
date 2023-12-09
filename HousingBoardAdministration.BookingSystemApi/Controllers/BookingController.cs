﻿using Microsoft.AspNetCore.Mvc;
using MediatR;
using BookingSystemApi.Application.Queris.Booking.Interface;
using BookingSystemApi.Application.Queris.Booking.Dto;
using BookingSystemApi.Application.Commands.Booking.Delete;
using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.Commands.Booking.Update;

namespace HousingBoardAdministration.BookingSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingGetQuery _bookingGetQuery;
        private readonly IBookingGetAllQuery _bookingGetAllQuery;
        private readonly IMediator _mediator;
        public BookingController(IBookingGetQuery bookingGetQuery, IBookingGetAllQuery bookingGetAllQuery, IMediator mediator)
        {
            _bookingGetQuery = bookingGetQuery;
            _bookingGetAllQuery = bookingGetAllQuery;
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

        [HttpGet("GetBookingsByUserId/{userId}")]
        public ActionResult<IEnumerable<BookingGetAllQueryResultDto>> GetAll(Guid userId)
        {
            var result = _bookingGetAllQuery.GetAll(userId);
            return result.ToList();

        }
        [HttpGet("{id}")]
        public ActionResult<BookingGetQueryResultDto> Get(Guid id) 
        { 
         var result = _bookingGetQuery.Get(id);
            return result;
        
        }
    }
}
