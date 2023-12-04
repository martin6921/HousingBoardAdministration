namespace BookingSystemApi.Application.Commands.Booking.Create
{
    public record CreateBookingCommand : IRequest
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid BookingOnwer {  get; set; }
        public List<Guid> ResourceIdsList { get; set; }

    }
}
