namespace Infrastructures.Models;

public class AddressModel
{
    public int Id { get; set; }

    public string StreetName { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
}
