using System;

namespace Persistence.Models
{
    public class ThreadWriteModel
    {
        public int ThreadId { get; set; }
        public string Data { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
