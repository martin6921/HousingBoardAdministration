using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Booking
{
    public class IndexModel : PageModel
    {
        private readonly IBookingBffClient _bookingBffClient;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(IBookingBffClient bookingBffClient, UserManager<IdentityUser> userManager)
        {
            _bookingBffClient = bookingBffClient;
            _userManager = userManager;
        }

        [BindProperty]
        public List<BookingViewModel> BookingViewModels { get; set; } = new();



        public async Task OnGet()
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            BookingViewModels = await _bookingBffClient.GetBookingsByuserId(userId);
        }
    }
}
