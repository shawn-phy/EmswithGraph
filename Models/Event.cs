public class Event
{
    public int EventId { get; set; }
    public string? EventName { get; set; }
    public DateTime EventDate { get; set; }
    public TimeSpan EventTime { get; set; }
    public string? Location { get; set; }
    public string? Description { get; set; }
    public int OrganizerId { get; set; }
    public Organizer Organizer { get; set; }
    public List<Attendee> Attendees { get; set; }
}

public class Organizer
{
    public int OrganizerId { get; set; }
    public string? OrganizerName { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactPhone { get; set; }
}

public class Attendee
{
    public int AttendeeId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string?   Phone { get; set; }
    public DateTime RegistrationDate { get; set; }
    public int EventId { get; set; }
}
