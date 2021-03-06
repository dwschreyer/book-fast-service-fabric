using BookFast.SeedWork.Modeling;

namespace BookFast.ReliableEvents
{
    public class ReliableEvent
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Tenant { get; set; }
        public Event Event { get; set; }
    }
}
