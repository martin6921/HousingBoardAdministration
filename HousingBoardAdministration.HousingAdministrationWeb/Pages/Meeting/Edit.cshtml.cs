using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting
{
    public class EditModel : PageModel
    {
        private IBffClient _bffClient;

        public EditModel(IBffClient bffClient)
        {
            this._bffClient = bffClient;
        }

        [BindProperty]
        public GetMeetingViewModel MeetingModel { get; set; } = new();
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
