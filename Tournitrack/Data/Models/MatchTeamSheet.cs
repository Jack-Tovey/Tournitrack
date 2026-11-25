namespace Tournitrack.Data.Models
{
    public class MatchTeamSheet
    {
        public int ID { get; set; }
        public int MatchID { get; set; }
        public int TeamID { get; set; }
        public string? CoachName { get; set; }
        public string? ManagerName { get; set; }
        public string? MedicalName { get; set; }

    }
}
