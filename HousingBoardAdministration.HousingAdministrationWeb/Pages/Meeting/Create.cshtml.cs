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

        //s�tter altid til en v�rdi for at undg� nullpointer exception
        //beh�ves ikke at lave noget med getteren men p� posten
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
