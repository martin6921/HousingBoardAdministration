using HousingBoardAdministration.HousingAdministrationWeb.Pages.Booking;
using System.ComponentModel.DataAnnotations;

namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Booking
{
    public record BookingCreateViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid BookingOwnerId { get; set; }
        public List<Guid> ResourceIdsList { get; set; }
    }
}
