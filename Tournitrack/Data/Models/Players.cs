using Microsoft.AspNetCore.Identity;
using Tournitrack.Data;

namespace Tournitrack.Data.Models
{
    public class Players
    {
        public int ID { get; set; }
        public string? AccountID { get; set; }
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public DateOnly dob { get; set; }
        [PersonalData]
        public int shirtNumber { get; set; }
        [PersonalData]
        public int ClubID { get; set; }
        [PersonalData]
        public string? Notes { get; set; }
    }
}
