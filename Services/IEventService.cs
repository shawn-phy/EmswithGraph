using EmswithGraph.Models;

public interface IEventService
{
    List<Event> GetEvents();
    int SaveEvent(Event event);
    }
