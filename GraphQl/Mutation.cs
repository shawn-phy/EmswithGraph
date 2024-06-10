using databaseService;

public class Mutation
{
    public int AddEvent(Event newEvent, [Service] IEventService eventService)
    {
        return eventService.AddEvent(newEvent);
    }

    public int UpdateEvent(Event updatedEvent, [Service] IEventService eventService)
    {
        return eventService.UpdateEvent(updatedEvent);
    }

    public int DeleteEvent(int eventId, [Service] IEventService eventService)
    {
        return eventService.DeleteEvent(eventId);
    }

    public int AddAttendee(Attendee newAttendee, [Service] IAttendeeService attendeeService)
    {
        return attendeeService.AddAttendee(newAttendee);
    }

    public int UpdateAttendee(Attendee updatedAttendee, [Service] IAttendeeService attendeeService)
    {
        return attendeeService.UpdateAttendee(updatedAttendee);
    }

    public int DeleteAttendee(int attendeeId, [Service] IAttendeeService attendeeService)
    {
        return attendeeService.DeleteAttendee(attendeeId);
    }
}
