using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Documents
{
    public class IndexModel : PageModel
    {
        public IndexModel() 
        { 
        }
        [BindProperty]
        public IFormFile Upload { get; set; }

        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {
            long length = Upload.Length;

            using var fileStream = Upload.OpenReadStream();
            byte[] bytes = new byte[length];
            fileStream.Read(bytes, 0, (int)Upload.Length);
        }
    }
}
