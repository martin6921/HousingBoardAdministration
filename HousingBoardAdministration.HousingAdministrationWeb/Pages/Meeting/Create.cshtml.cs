using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting
{
    [Authorize(Policy = "IsAdminPolicy")]
    public class CreateModel : PageModel
    {
        private IBffClient _bffClient;
        public CreateModel(IBffClient bffClient)
        {
            this._bffClient = bffClient;
        }

        //sætter altid til en værdi for at undgå nullpointer exception
        //behøves ikke at lave noget med getteren men på posten
        [BindProperty]
        public MeetingCreateViewModel MeetingModel { get; set; }
        [BindProperty]
        public Guid SelectedMeetingType { get; set; }
        public List<MeetingTypeViewModel> ListOfAllMeetingTypes { get; set; } = new();
        public SelectList MeetingTypeSelectList { get; set; }
        public async Task OnGet()
        {
            ListOfAllMeetingTypes = await _bffClient.GetAllMeetingTypesAsync();
            MeetingTypeSelectList = new SelectList(ListOfAllMeetingTypes, "Id","Type");
        }
        public IActionResult OnPost()
        {
            MeetingModel.MeetingTypeId = SelectedMeetingType;
            _bffClient.CreateMeetingAsync(MeetingModel);
            return RedirectToPage("./index");
        }
    }
}
