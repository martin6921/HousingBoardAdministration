using HousingBoardAdministration.HousingAdministrationWeb.Areas.Identity.Pages.Account.ListViewModels;
using HousingBoardAdministration.HousingAdministrationWeb.Pages.Booking;
using HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document;
using RestEase;

namespace HousingBoardAdministration.HousingAdministrationWeb;

public interface IBookingBffClient
{
    //attribute body
    [Post("/resident")]
    Task CreateResidentAsync([Body]CreateResidentDto createResidentDto);

    [Get("/Booking/GetBookingsByUserId/{userId}")]
    Task<List<BookingViewModel>> GetBookingsByuserId([Path]Guid userId);
    [Post("/Booking")]
    Task CreateBookingAsync([Body]CreateBookingViewModel createBookingViewModel);
    [Get("/ressource")]
    Task<List<ResourceViewModel>> GetAllResourcesAsync();
}
