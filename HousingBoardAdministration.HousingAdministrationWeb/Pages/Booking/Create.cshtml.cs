using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Booking
{

    public class CreateModel : PageModel
    {
        private IBffClient _bffClient;

        public CreateModel(IBffClient bffClient)
        {
            _bffClient = bffClient;
        }

        [BindProperty]
        public CreateBookingViewModel Booking { get; set; } = new CreateBookingViewModel();

        public List<ResourceViewModel> AllResources { get; set; } = new List<ResourceViewModel>();

        public SelectList ResourceSelectList { get; set; }

        public async Task OnGetAsync()
        {
            // Hent ressource-listen som ResourceViewModel og opret en SelectList til dropdown-menuen
            AllResources = await _bffClient.GetAllResourcesAsync();
            ResourceSelectList = new SelectList(AllResources, "Id", "Description");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                // Opret booking ved hjælp af _bffClient
                await _bffClient.CreateBookingAsync(Booking);

                // Redirect til en bekræftelsesside eller en oversigtsside TODO
                return RedirectToPage("/Booking/Confirmation");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Der skete en fejl ved oprettelse: " + ex.Message);
                return Page();
            }
        }
    }
}

