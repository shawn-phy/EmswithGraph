using System.Collections.Generic;

public interface IEventService
{
    List<Event> GetEvents();
    Event GetEvent(int id);
    int AddEvent(Event newEvent);
    int UpdateEvent(Event updatedEvent);
    int DeleteEvent(int id);
}
