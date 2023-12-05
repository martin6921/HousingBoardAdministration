using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.HousingBoard.BoardMember
{
    public class GetModel : PageModel
    {
        //interface backend for frontend client
        private readonly IBffClient _bffClient;

        public GetModel(IBffClient bffClient)
        {

            this._bffClient = bffClient;
        }


        [BindProperty]
        public BoardMemberWithAllRolesViewModel BoardMemberViewModel { get; set; }
        public async Task<ActionResult> OnGet(Guid id)
        {
            BoardMemberViewModel = await _bffClient.GetBoardMemberWithAllRolesAsync(id, true);
            return Page();
        }
    }
}
