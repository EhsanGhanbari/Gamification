using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class NotificationMap : EntityBaseMap<Notification>
    {
        protected NotificationMap()
        {
            Table("Notification");
            Not.LazyLoad();
            Map(t => t.Body).Length(500).Not.Nullable();
            Map(t => t.IsRead);
            Map(t => t.IsDisabledForAlert);
        }
    }
}
