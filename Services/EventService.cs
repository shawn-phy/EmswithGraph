using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using EmswithGraph.Services;

namespace HotChoco.Dapper.Api.Services
{
    public class EventService : IEventService
    {
        private readonly IConfiguration _configuration;

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_configuration.GetConnectionString("DefaultString"));
            }
        }
        public EventService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

    }
}