using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Documents
{
    public class CreateModel : PageModel
    {
        private readonly IBffClient _bffClient;

        public CreateModel(IBffClient bffClient)
        {
            _bffClient = bffClient;
        }

        [BindProperty]
        public DocumentCreateViewModel DocumentModel { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {
            long length = Upload.Length;

            //add length check mayb

            using var fileStream = Upload.OpenReadStream();
            byte[] bytes = new byte[length];
            fileStream.Read(bytes, 0, (int)Upload.Length);
            DocumentModel.DocumentFile = Convert.ToBase64String(bytes);
            string base64text = Convert.ToBase64String(bytes);

            //byte[] newByte = Convert.FromBase64String(base64text);

            await _bffClient.CreateDocumentAsync(DocumentModel);

           // System.IO.File.WriteAllBytes("C:\\Users\\Martin\\Desktop\\dbabay\\hjælp.pdf", newByte);
        }
    }
}
