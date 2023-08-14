
public class Attendee
{
    public int AttendeeId { get; set; }
    public string Name { get; set; }
    // Other properties...

    public int EventId { get; set; }
    public Event Event { get; set; }
}
