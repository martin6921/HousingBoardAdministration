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


    [Post("/booking")]
    Task CreateBookingAsync([Body] CreateBookingViewModel booking);

    [Get("/resource")]
    Task<List<ResourceViewModel>> GetAllResourcesAsync();
}
