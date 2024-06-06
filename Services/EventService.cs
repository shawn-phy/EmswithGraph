using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace databaseService
{
    public class EventService : IEventService
    {
        private readonly IConfiguration _configuration;
        private string ConnectionString => _configuration.GetConnectionString("DefaultConnection");

        public EventService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Event> GetEvents()
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.Query<Event>("EXEC spGetEvents").ToList();
        }

        public Event GetEvent(int id)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.QueryFirstOrDefault<Event>("EXEC spGetEvent @EventId", new { EventId = id });
        }

        public int AddEvent(Event newEvent)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.Execute("EXEC spAddEvent @EventName, @EventDate, @EventTime, @Location, @Description, @OrganizerID",
                new
                {
                    EventName = newEvent.EventName,
                    EventDate = newEvent.EventDate,
                    EventTime = newEvent.EventTime,
                    Location = newEvent.Location,
                    Description = newEvent.Description,
                    OrganizerID = newEvent.OrganizerId
                });
        }
        public int UpdateEvent(Event updatedEvent)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.Execute("EXEC spUpdateEvent @EventId, @EventName, @EventDate, @EventTime, @Location, @Description, @OrganizerID",
                new {
                    updatedEvent.EventId,
                    updatedEvent.EventName,
                    updatedEvent.EventDate,
                    updatedEvent.EventTime,
                    updatedEvent.Location,
                    updatedEvent.Description,
                    updatedEvent.OrganizerId
                });
        }

        public int DeleteEvent(int id)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.Execute("EXEC spDeleteEvent @Id", new { Id = id });
        }
    }
}