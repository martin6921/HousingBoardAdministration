using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.Mime.MediaTypeNames;

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

            //Create new document from byte array

            System.IO.File.WriteAllBytes("C:\\Users\\marti\\Desktop\\bytetest\\hjælp.pdf", bytes);
        }
    }
}
