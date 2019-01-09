using System;
using System.Collections.Generic;
using Gamification.Application.Model;

namespace Gamification.Application.BusinessTask
{
    internal class EntityBaseBusiness<TEntity> : IEntityBase<TEntity> where TEntity : EntityBase
    {
        public void Add(TEntity entity)
        {
            AddEntityBase(entity);
            SessionFactory.GetCurrentSession().Save(entity);
        }

        public void Remove(Guid id)
        {
            var entity = SessionFactory.GetCurrentSession().Get<TEntity>(id);
            SessionFactory.GetCurrentSession().Delete(entity);
        }

        public void Update(TEntity entity)
        {
            SessionFactory.GetCurrentSession().SaveOrUpdate(entity);
        }

        public TEntity GetById(Guid id)
        {
            return SessionFactory.GetCurrentSession().Get<TEntity>(id);
        }

        public IList<TEntity> GetAll()
        {
            var criteriaQuery = SessionFactory.GetCurrentSession().CreateCriteria(typeof(TEntity));
            return criteriaQuery.List<TEntity>();
        }

        public void SaveChanges()
        {
            using (var transaction = SessionFactory.GetCurrentSession().BeginTransaction())
            {
                try
                {
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private static void AddEntityBase(TEntity entity)
        {
            entity.CreationTime = DateTime.Now;
            entity.IsDeleted = false;
        }
    }
}
