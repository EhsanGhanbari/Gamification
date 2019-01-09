using System;

namespace Gamification.Service.DataModel
{
    public class TaskView
    {
        public Guid TaskId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Pending { get; set; }
        public bool IsRead { get; set; }
    }
}
