using System.Collections.Generic;
using System.Linq;
using Gamification.Application.Model;
using NHibernate.Linq;
using Task = Gamification.Application.Model.Task;


namespace Gamification.Application.BusinessTask
{
    public interface ITaskBusiness : IEntityBase<Task>
    {
        IList<Task> GetAllPendingTasks();
    }

    internal class TaskBusiness : EntityBaseBusiness<Task>, ITaskBusiness
    {
        public IList<Task> GetAllPendingTasks()
        {
            return SessionFactory.GetCurrentSession().Query
              <Task>().Where(n => n.IsDeleted == false && n.IsDeleted == false && n.Pending)
              .OrderBy(c => c.CreationTime).ToList();
        }
    }
}
