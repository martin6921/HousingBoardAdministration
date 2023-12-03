using HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting
{
    public class GetModel : PageModel
    {
        private IBffClient _bffClient;

        public GetModel(IBffClient bffClient)
        {
            this._bffClient = bffClient;
        }
        [BindProperty]
        public List<DocumentViewModel> Documents { get; set; }

        [BindProperty]
        public GetMeetingViewModel MeetingModel { get; set; } = new();

        [BindProperty]
        public IFormFile Upload { get; set; }
        public async Task<IActionResult> OnGet(Guid id)
        {
            MeetingModel = await _bffClient.GetMeetingAsync(id);
            
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            //await _bffClient.EditResourceAsync(ResourceModel);

            return RedirectToPage("./Index");
        }
    }
}
