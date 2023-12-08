using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Resource
{
    public class GetModel : PageModel
    {
        private readonly IBffClient _bffClient;
        public GetModel(IBffClient bffClient)
        {
            _bffClient = bffClient;
        }

        [BindProperty]
        public List<GetResourceViewModel> ResourceModels { get; set; } = new();

        public async Task OnGetAsync()
        {
            var resources = await _bffClient.GetAllResourcesAsync();

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


