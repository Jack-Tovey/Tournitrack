namespace Tournitrack.Data.Models
{
    public class PlayerGoals
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public int MatchID { get; set; }
        public string GoalType { get; set; }
        public int MatchMinute { get; set; }
    }
}
