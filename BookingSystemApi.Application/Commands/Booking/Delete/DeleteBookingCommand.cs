namespace BookingSystemApi.Application.Commands.Booking.Delete
{
    public record DeleteBookingCommand : IRequest
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
