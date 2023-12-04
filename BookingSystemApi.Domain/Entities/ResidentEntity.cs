using System.ComponentModel.DataAnnotations.Schema;


namespace BookingSystemApi.Domain.Entities;

public class ResidentEntity : BaseEntity
{
    //For EF purpose only!
    public ResidentEntity() { }
    public ResidentEntity(string username, string firstname, string lastname, string residentaddress) 
    { 
        UserName = username;
        FirstName = firstname;
        LastName = lastname;
        ResidentAddress = residentaddress;
    }
   

    public void Edit(string firstName, string lastName, string userName, string residentAddress)
    {
        this.UserName = userName;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.ResidentAddress = residentAddress;
        
    }

    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ResidentAddress { get; set; }
    public ICollection<BookingEntity>? Bookings { get; set; }
   // public string FullName { get { return FullName; } set { FullName = FirstName + " " + LastName; } }




}
