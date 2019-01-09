using Gamification.Application.Model;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Gamification.Application.BusinessTask
{
    public interface INotificationBusiness : IEntityBase<Notification>
    {
        IList<Notification> GetAllNotifications();
        IList<Notification> GetAllUnreadNotifications();
    }

    internal class NotificationBusiness : EntityBaseBusiness<Notification>, INotificationBusiness
    {
        public IList<Notification> GetAllNotifications()
        {
            return SessionFactory.GetCurrentSession().Query
                <Notification>().Where(n => n.IsDeleted == false)
                .OrderBy(c => c.CreationTime).ToList();
        }

        public IList<Notification> GetAllUnreadNotifications()
        {
            return SessionFactory.GetCurrentSession().Query
                <Notification>().Where(n => n.IsRead == false && n.IsDeleted == false)
                .OrderBy(c => c.CreationTime).ToList();
        }
    }
}
