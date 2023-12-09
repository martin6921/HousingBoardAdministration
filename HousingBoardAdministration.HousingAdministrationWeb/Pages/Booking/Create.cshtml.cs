using HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Booking
{
    public class CreateModel : PageModel
    {
        private IBookingBffClient _bookingBffClient;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateModel(IBookingBffClient bookingBffClient, UserManager<IdentityUser> userManager)
        {
            _bookingBffClient = bookingBffClient;
            _userManager = userManager;
        }

        [BindProperty]
        public CreateBookingViewModel BookingModel { get; set; } = new();
        public List<ResourceViewModel> AllResources { get; set; } = new();

        public async Task OnGetAsync()
        {
            AllResources = await _bookingBffClient.GetAllResourcesAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            BookingModel.BookingOwnerId = Guid.Parse(_userManager.GetUserId(User));

            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                // Opret booking ved hjælp af _bffClient
                await _bookingBffClient.CreateBookingAsync(BookingModel);

                // Redirect til en bekræftelsesside eller en oversigtsside TODO
                return RedirectToPage("./index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Der skete en fejl ved oprettelse: " + ex.Message);
                return Page();
            }
            return Page();
        }
    }
}
