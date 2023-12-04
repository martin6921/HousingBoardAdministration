using HousingBoardAdministration.HousingAdministrationWeb.Areas.Identity.Pages.Account.ListViewModels;
using HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting;
using HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document;
using RestEase;

namespace HousingBoardAdministration.HousingAdministrationWeb
{
    public interface IBffClient
    {

        //attribute body
        [Post("/document")]
        Task CreateDocumentAsync([Body]DocumentCreateViewModel documentCreateViewModel);
        [Get("/document/{id}")]
        Task<DocumentViewModel> GetDocumentAsync([Path] Guid id);

        [Get("/role")]
        Task<List<RoleViewModel>> GetAllRolesAsync();


        [Post("/boardmember")]
        Task CreateBoardMemberAsync([Body]CreateBoardMemberDto createBoardMemberDto);

        [Get("/meeting")]
        Task<List<MeetingTypeIndexViewModel>> GetAllMeetingsAsync();

        [Get("/meeting/{id}")]
        Task<GetMeetingViewModel> GetMeetingAsync([Path]Guid id);

        [Get("/documenttype")]
        Task<List<DocumentTypeViewModel>> GetAllDocumentTypesAsync();


    }
}
