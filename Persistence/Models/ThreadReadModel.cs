using System;

namespace Persistence.Models
{
    public class ThreadReadModel
    {
        public int ThreadId { get; set; }
        public string Data { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
