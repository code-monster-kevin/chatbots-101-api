using Chatbot101.API.Data.Entity;

namespace Chatbot101.API.Data.Repository
{
    public interface IIncomingDataRepository
    {
        bool Save();
        void SetIncomingData(IncomingData data);
    }
}