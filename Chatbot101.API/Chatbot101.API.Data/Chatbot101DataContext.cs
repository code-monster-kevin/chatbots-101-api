using Chatbot101.API.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Chatbot101.API.Data
{
    public class Chatbot101DataContext : DbContext
    {
        public Chatbot101DataContext(DbContextOptions<Chatbot101DataContext> options) : base(options)
        {

        }

        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<IncomingData> IncomingData { get; set; }
    }
}
