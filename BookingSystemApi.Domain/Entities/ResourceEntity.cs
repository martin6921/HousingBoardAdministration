namespace BookingSystemApi.Domain.Entities;

public class ResourceEntity : BaseEntity
{
    //EF purpose only
    internal ResourceEntity() { }
    public ResourceEntity(string description, string specification, int price)
    {
        //Check pre-condition

        //Logic

        //Post-condition

        this.Description = description;
        this.Specification = specification;
        this.Price = price;
    }

    public List<BookingEntity>? Bookings { get; set; }
    public string Description { get; set; }
    public string Specification { get; set; }
    public decimal Price { get; set; }
}
