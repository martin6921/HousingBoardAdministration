using BookingSystemApi.Application.IRepositories;

namespace BookingSystemApi.Application.Commands.Booking.Create;

public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand>
{
    private readonly IBookingRepository _bookingRepository;

    public CreateBookingCommandHandler(IBookingRepository resourceRepository)
    {
        _bookingRepository = resourceRepository;
    }

    public Task Handle(CreateBookingCommand request, CancellationToken cancellationToken)
    {
        _bookingRepository.Create(request);
        return Task.CompletedTask;
    }
}

