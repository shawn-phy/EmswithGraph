using EmswithGraph.Models;

namespace EmswithGraph.Models
{
    public class Events
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Attendees> Attendees { get; set; }
    }
}