using HousingBoardAdministration.HousingAdministrationWeb.Areas.Identity.Pages.Account.ListViewModels;
using HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.HousingBoard.BoardMember
{
    public class EditModel : PageModel
    {
        private IBffClient _bffClient;

        public EditModel(IBffClient bffClient)
        {
            this._bffClient = bffClient;
        }


        [BindProperty]
        public BoardMemberWithCurrentRoleViewModel BoardMemberViewModel { get; set; } = new();


        [BindProperty]
        public Guid SelectedRoleType { get; set; }
        public List<RoleViewModel> ListOfAllRoles { get; set; } = new();
        public SelectList RoleSelectList { get; set; }


        public async Task<ActionResult> OnGet(Guid id)
        {
            var boardmember = await _bffClient.GetBoardMemberWithAllRolesAsync(id, false);

            BoardMemberViewModel = new BoardMemberWithCurrentRoleViewModel
            {
                Id = boardmember.Id,
                FirstName = boardmember.FirstName,
                LastName = boardmember.LastName,
                BoardMemberRoleId = boardmember.BoardMemberRoles.FirstOrDefault().Role.Id,
                ResidentAddress = boardmember.ResidentAddress,
                RowVersion = boardmember.RowVersion

            };

            ListOfAllRoles = await _bffClient.GetAllRolesAsync();

            RoleSelectList = new SelectList(ListOfAllRoles, "Id", "RoleName");

            SelectedRoleType = BoardMemberViewModel.BoardMemberRoleId;

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            await _bffClient.EditBoardMemberAsync(new BoardMemberEditViewModel 
            {
                Id = BoardMemberViewModel.Id,
                FirstName = BoardMemberViewModel.FirstName,
                LastName = BoardMemberViewModel.LastName,
                ResidentAddress = BoardMemberViewModel.ResidentAddress,
                RowVersion = BoardMemberViewModel.RowVersion
            });

            if (BoardMemberViewModel.BoardMemberRoleId == SelectedRoleType)
            {
                return RedirectToPage("/Housingboard/index");
            }

            await _bffClient.CreateBoardMemberRoleAsync(new CreateBoardMemberRoleDto 
            {
                RoleId = SelectedRoleType,
                BoardMemberId = BoardMemberViewModel.Id
            });


            return RedirectToPage("/Housingboard/index");
        }
    }
}
