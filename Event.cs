
public class Event
{
    public int EventId { get; set; }
    public string EventName { get; set; }
    // Other properties...
    
    public ICollection<Attendee> Attendees { get; set; }
}

