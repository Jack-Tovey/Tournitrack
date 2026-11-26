using Microsoft.AspNetCore.Identity;

namespace Tournitrack.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    public string? FirstName { get; set;  }
    [PersonalData]
    public string? LastName { get; set; }
    public int? TeamID { get; set; }
}