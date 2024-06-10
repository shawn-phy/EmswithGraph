using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace databaseService
{
    public class AttendeeService : IAttendeeService
    {
        private readonly IConfiguration _configuration;
        private string ConnectionString => _configuration.GetConnectionString("DefaultConnection");

        public AttendeeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Attendee> GetAttendees()
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.Query<Attendee>("EXEC spGetAttendees").ToList();
        }

        public Attendee GetAttendee(int id)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.QueryFirstOrDefault<Attendee>("EXEC spGetAttendee @AttendeeId", new { AttendeeId = id });
        }

        public int AddAttendee(Attendee newAttendee)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.Execute("EXEC spAddAttendee @FirstName, @LastName, @Email, @Phone, @RegistrationDate, @EventId",
                new
                {
                    newAttendee.FirstName,
                    newAttendee.LastName,
                    newAttendee.Email,
                    newAttendee.Phone,
                    newAttendee.RegistrationDate,
                    newAttendee.EventId
                });
        }

        public int UpdateAttendee(Attendee updatedAttendee)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.Execute("EXEC spUpdateAttendee @AttendeeId, @FirstName, @LastName, @Email, @Phone, @RegistrationDate, @EventId",
                new
                {
                    updatedAttendee.AttendeeId,
                    updatedAttendee.FirstName,
                    updatedAttendee.LastName,
                    updatedAttendee.Email,
                    updatedAttendee.Phone,
                    updatedAttendee.RegistrationDate,
                    updatedAttendee.EventId
                });
        }

        public int DeleteAttendee(int id)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn.Execute("EXEC spDeleteAttendee @AttendeeId", new { AttendeeId = id });
        }
    }
}
