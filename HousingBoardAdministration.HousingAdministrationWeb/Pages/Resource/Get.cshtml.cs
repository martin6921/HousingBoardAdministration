using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Resource
{
    public class GetModel : PageModel
    {
        private readonly IBookingBffClient _bookingBffClient;
        public GetModel(IBookingBffClient bookingBffClient)
        {
            _bookingBffClient = bookingBffClient;
        }

        [BindProperty]
        public List<GetResourceViewModel> ResourceModels { get; set; } = new();

        public async Task OnGetAsync()
        {
            var resources = await _bookingBffClient.GetAllResourcesAsync();

            ResourceModels = resources.Select(resource => new GetResourceViewModel
            {
                Id = resource.Id,
                Description = resource.Description,
                Specification = resource.Specification,
                Price = resource.Price,
            }).ToList();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            return RedirectToPage("./Index");
        }
    }
}


