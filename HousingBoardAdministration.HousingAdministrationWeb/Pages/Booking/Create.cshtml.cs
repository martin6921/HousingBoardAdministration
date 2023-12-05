using HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Booking
{
    public class CreateModel : PageModel
    {
        private readonly IBffClient _bffClient;

        public CreateModel(IBffClient bffClient)
        {
            _bffClient = bffClient;
        }
        [BindProperty]
        public BookingCreateViewModel NewBooking { get; set; } = new();

        public async Task OnGet(Guid id)
        {
           NewBooking.BookingOwnerId = id;
           NewBooking.StartDate = DateTime.Now;
           NewBooking.EndDate = DateTime.Now;
           NewBooking.ResourceIdsList = new List<Guid>();
        }

    }
}
