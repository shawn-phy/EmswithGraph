using System.Collections.Generic;

namespace databaseService
{
    public interface IAttendeeService
    {
        List<Attendee> GetAttendees();
        Attendee GetAttendee(int id);
        int AddAttendee(Attendee newAttendee);
        int UpdateAttendee(Attendee updatedAttendee);
        int DeleteAttendee(int id);
    }
}
