using System;

namespace Chatbot101.API.Data.Entity
{
    public class IncomingData
    {
        public Guid ID { get; set; }
        public string ReferenceID { get; set; }
        public string RawData { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsProcessed { get; set; }
    }
}
