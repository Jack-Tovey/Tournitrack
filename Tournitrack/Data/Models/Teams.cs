namespace Tournitrack.Data.Models
{
    public class Teams
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public int ClubID { get; set; }
        public string HomeTopColour { get; set; }
        public string HomeShortColour { get; set; }
        public string HomeSockColour { get; set; }
        public string AwayTopColour { get; set; }
        public string AwayShortColour { get; set; }
        public string AwaySockColour { get; set; }

    }
}
