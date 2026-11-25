namespace Tournitrack.Data.Models
{
    public class TournamentOfficials
    {
        public int ID { get; set; }
        public int TournamentID { get; set; }
        public string UserID { get; set; }
        public int RoleID { get; set; }
    }
}
