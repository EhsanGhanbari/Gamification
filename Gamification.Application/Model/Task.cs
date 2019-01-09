namespace Gamification.Application.Model
{
    public class Task : EntityBase
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Pending { get; set; }
        public bool IsRead { get; set; }
    }
}
