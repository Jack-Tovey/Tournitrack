namespace Tournitrack.Data.Models
{
    public class PlayerCards
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public int MatchID { get; set; }
        public int MatchMinute { get; set; }
        public string CardType { get; set; }
    }
}
