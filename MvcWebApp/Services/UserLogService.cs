using MvcMongoApp.Models;
using MongoDB.Driver;


namespace MvcMongoApp.Services
{
    public class UserLogService
    {
        private readonly IMongoCollection<UserLog> _userLogs;

        public UserLogService(IMongoClient client)
        {
            var database = client.GetDatabase("UserLogsDB");
            _userLogs = database.GetCollection<UserLog>("UserLogs");
        }

        // Retrieves the 5 most recent logs
        public List<UserLog> GetLatestLogs()
        {
            return _userLogs.Find(log => true)
                            .SortByDescending(log => log.VisitDateTime)
                            .Limit(5)
                            .ToList();
        }

        // Adds a new log entry and keeps only the last 5 records and overwriting the 5th log with 4th log while new log is entered.
        public void AddUserLog(string ipAddress)
        {
            var log = new UserLog { IpAddress = ipAddress, VisitDateTime = System.DateTime.UtcNow };
            _userLogs.InsertOne(log);

            
            var logsCount = _userLogs.CountDocuments(log => true);
            if (logsCount > 5)
            {
                var oldestLog = _userLogs.Find(log => true)
                                         .SortBy(log => log.VisitDateTime)
                                         .Limit(1)
                                         .FirstOrDefault();
                if (oldestLog != null)
                {
                    _userLogs.DeleteOne(log => log.Id == oldestLog.Id);
                }
            }
        }
    }
}
