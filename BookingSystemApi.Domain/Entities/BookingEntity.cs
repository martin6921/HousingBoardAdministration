namespace BookingSystemApi.Domain.Entities;

public class BookingEntity : BaseEntity
{
    //EF purpose only
    public BookingEntity()
    {
    }

    public BookingEntity(List<ResourceEntity> resources, DateTime startDate, DateTime endDate)
    {
        Resources = resources;
        StartDate = startDate;
        EndDate = endDate;
    }

    public List<ResourceEntity> Resources { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
