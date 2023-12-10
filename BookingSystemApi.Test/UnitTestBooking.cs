using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Booking.Dto;


namespace BookingSystemApi.Test
{
    public class UnitTestBooking 
    {
        //[Fact]
        //public async Task Handler_Should_ReturnFailureResult_WhenBookingIsOverlapping()
        //{
        //    //Arrange
        //    var mockRepo = new Mock<IBookingRepository>();
        //    //laver moq data der vil forsage overlap
        //    //Act
        //    mockRepo.Setup(repo => repo.GetAll()).Returns(new List<BookingGetAllQueryResultDto>
        //{
        //    new BookingGetAllQueryResultDto
        //    {
        //        Id = Guid.NewGuid(), 
        //        RowVersion = new byte[0], 
        //        StartDate = new DateTime(2023, 1, 1),
        //        EndDate = new DateTime(2023, 1, 10)
        //    }
            
        //});
        //    //Act
        //    mockRepo.Setup(repo => repo.Create(It.IsAny<CreateBookingCommand>())).Throws(new InvalidOperationException("Booking overlapper med eksisterenede booking"));
        //    var handler = new CreateBookingCommandHandler(mockRepo.Object);
        //    var command = new CreateBookingCommand
        //    {
        //        StartDate = new DateTime(2023, 1, 5),
        //        EndDate = new DateTime(2023, 1, 15),
        //        BookingOwnerId = Guid.NewGuid(),
        //        ResourceIdsList = new List<Guid> { Guid.NewGuid() }
        //    };
            
        //    //Assert
        //    var exeption = await Assert.ThrowsAsync<InvalidOperationException>(() => handler.Handle(command, new CancellationToken()));

        //    Assert.Equal("Bookoing overlapper med eksisterende booking", exeption.Message);
        //}
       
    }
}