using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class TaskMap : EntityBaseMap<Task>
    {
        public TaskMap()
        {
            Table("Task");
            Not.LazyLoad();
            Map(t => t.Title).Length(50).Not.Nullable();
            Map(t => t.Body).Length(500).Not.Nullable();
            Map(t => t.IsRead);
            Map(t => t.Pending);
        }
    }
}
