
using BookingSystemApi.Application.Commands.Booking.Create;
using BookingSystemApi.Application.IRepositories;
using System.Resources;

namespace BookingSystemApi.Application.Commands.Booking.Edit;

    public class EditBookingCommandHandler : IRequestHandler<CreateBookingCommand>
    {
        private readonly IBookingRepository _bookingRepository;

        public EditBookingCommandHandler(IBookingRepository resourceRepository)
        {
            _bookingRepository = resourceRepository;
        }

        public Task Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
        var model = _bookingRepository.Load(request.Id);

        //DoIt
        model.Edit(request.StartDate, request.EndDate);

        //Save
        _bookingRepository.Edit(model);
        return Task.CompletedTask;
        }
    }

