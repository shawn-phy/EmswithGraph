using databaseService;

public class Query
{
    public List<Event> GetEvents([Service] IEventService eventService) => eventService.GetEvents();
    public Event GetEvent(int eventId, [Service] IEventService eventService) => eventService.GetEvent(eventId);

    public List<Attendee> GetAttendees([Service] IAttendeeService attendeeService) => attendeeService.GetAttendees();
    public Attendee GetAttendee(int attendeeId, [Service] IAttendeeService attendeeService) => attendeeService.GetAttendee(attendeeId);
}
