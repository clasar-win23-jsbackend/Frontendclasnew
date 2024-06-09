using Microsoft.AspNetCore.Identity;

namespace Frontendclasnew.Data;
public class ApplicationUser : IdentityUser
{

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
    public string? ProfileImg { get; set; } = "avatar.jpg";
    public string? Bio { get; set; }

    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }

}


public class AddressEntity
{
    public int Id { get; set; }
    public string AddressLine_1 { get; set; } = null!;
    public string? AddressLine_2 { get; set; }

    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
}
