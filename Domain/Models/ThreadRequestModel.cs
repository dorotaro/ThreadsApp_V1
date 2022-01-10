using System;

namespace Domain.Models
{
    public class ThreadRequestModel
    {
        public int ThreadId { get; set; }
        public string Data { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
