using HousingBoardAdministration.HousingAdministrationWeb.Pages.Documents;
using RestEase;

namespace HousingBoardAdministration.HousingAdministrationWeb
{
    public interface IBffClient
    {

        //attribute body
        [Post("/document")]
        Task CreateResourceAsync([Body] DocumentCreateViewModel documentCreateViewModel);


    }
}
