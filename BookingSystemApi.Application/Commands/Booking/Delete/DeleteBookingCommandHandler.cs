

using BookingSystemApi.Application.IRepositories;

namespace BookingSystemApi.Application.Commands.Booking.Delete;

    public class DeleteBookingCommandHandler: IRequestHandler<DeleteBookingCommand>
    {

    private readonly IBookingRepository _bookingRepository;

    public DeleteBookingCommandHandler(IBookingRepository resourceRepository)
    {
        _bookingRepository = resourceRepository;
    }

    public async Task Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
    {


    }
}

