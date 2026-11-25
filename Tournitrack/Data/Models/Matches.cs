namespace Tournitrack.Data.Models
{
    public class Matches
    {
        public int ID { get; set; }
        public int TournamentID { get; set; }
        public DateTime ScheduledMatchDateTime { get; set; }
        public DateTime? ActualMatchDateTime { get; set; }
        public int TeamIDHome { get; set; }
        public int? HomeTeamSheetID { get; set; }
        public int TeamIDAway { get; set; }
        public int? AwayTeamSheetID { get; set; }
        public int PitchNumber { get; set; }
        public int? PoolID { get; set; }
        public string? Description { get; set; }
        public double GameLength { get; set; }
        public bool MatchComplete { get; set; }
        public bool ResultNeeded { get; set; }
    }
}
