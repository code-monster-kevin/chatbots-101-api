using Chatbot101.API.Data.Entity;

namespace Chatbot101.API.Data.Repository
{
    public interface IActivityLogRepository
    {
        bool Save();
        void SetActivityLog(ActivityLog activitylog);
    }
}