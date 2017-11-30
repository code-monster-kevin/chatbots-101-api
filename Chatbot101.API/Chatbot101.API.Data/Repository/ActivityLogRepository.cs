using Chatbot101.API.Data.Entity;

namespace Chatbot101.API.Data.Repository
{
    public class ActivityLogRepository : IActivityLogRepository
    {
        private Chatbot101DataContext _db;

        public ActivityLogRepository(Chatbot101DataContext db)
        {
            _db = db;
        }

        public void SetActivityLog(ActivityLog activitylog)
        {
            _db.ActivityLogs.Add(activitylog);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0;
        }
    }
}
