namespace HousingBoardAdministration.HousingAdministrationWeb.Pages.Booking
{
    public record BookingViewModel
    {
        public Guid Id { get; set; }
        public List<Guid> ResourceIdsList { get; set; }
    }
}
