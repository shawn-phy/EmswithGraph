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
}
