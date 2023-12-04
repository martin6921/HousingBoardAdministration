using HousingBoardAdministration.HousingAdministrationWeb.Areas.Identity.Pages.Account.ListViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document
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

        public static Guid MeetingId { get; set; }


        [BindProperty]
        public List<DocumentTypeViewModel> ListOfAllDocumentTypes { get; set; } = new();
        public SelectList DocumentTypeSelectList { get; set; }
        [BindProperty]
        public Guid SelectedDocumentTypeId { get; set; }

        public async Task OnGet(Guid id)
        {
            ListOfAllDocumentTypes = await _bffClient.GetAllDocumentTypesAsync();
            DocumentTypeSelectList = new SelectList(ListOfAllDocumentTypes, "Id","Type");
            MeetingId = id;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            long length = Upload.Length;

            DocumentModel.MeetingId = MeetingId;
            DocumentModel.DocumentTypeId = SelectedDocumentTypeId;
            //add length check mayb

            using var fileStream = Upload.OpenReadStream();
            byte[] bytes = new byte[length];
            fileStream.Read(bytes, 0, (int)Upload.Length);
            DocumentModel.DocumentFile = Convert.ToBase64String(bytes);
            string base64text = Convert.ToBase64String(bytes);

            //byte[] newByte = Convert.FromBase64String(base64text);

            await _bffClient.CreateDocumentAsync(DocumentModel);
            return RedirectToPage("/Meeting/Get", new { id = MeetingId });

            // System.IO.File.WriteAllBytes("C:\\Users\\Martin\\Desktop\\dbabay\\hj�lp.pdf", newByte);
        }
    }
}
