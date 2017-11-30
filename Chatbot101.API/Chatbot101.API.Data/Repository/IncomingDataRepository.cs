using Chatbot101.API.Data.Entity;

namespace Chatbot101.API.Data.Repository
{
    public class IncomingDataRepository : IIncomingDataRepository
    {
        private Chatbot101DataContext _db;

        public IncomingDataRepository(Chatbot101DataContext db)
        {
            _db = db;
        }

        public void SetIncomingData(IncomingData data)
        {
            _db.IncomingData.Add(data);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0;
        }
    }
}
