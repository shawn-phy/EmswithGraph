using databaseService;

public class Query
{
    public List<Event> GetEvents([Service] IEventService eventService) => eventService.GetEvents();
    public Event GetEvent(int eventId, [Service] IEventService eventService) => eventService.GetEvent(eventId);
}
