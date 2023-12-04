using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Meeting.Document
{
    public class DeleteModel : PageModel
    {
        private readonly IBffClient _bffClient;

        public DeleteModel(IBffClient bffClient)
        {
            this._bffClient = bffClient;
        }
        public static Guid MeetingId { get; set; }

        [BindProperty]
        public DocumentDeleteViewModel DocumentModel { get; set; } = new();
        public async Task<IActionResult> OnGet(Guid meetingId, Guid documentId)
        {
            MeetingId = meetingId;
            var dto = await _bffClient.GetDocumentAsync(documentId);

            DocumentModel = new DocumentDeleteViewModel
            {
                Id = dto.Id
            };
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            await _bffClient.DeleteDocumentAsync(DocumentModel);

            return RedirectToPage("/Meeting/Get", new { id = MeetingId });
        }
    }
}
