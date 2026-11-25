namespace Tournitrack.Data.Models
{
    public class OfficialAvailability
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public DateTime Date { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Evening { get; set; }
    }
}