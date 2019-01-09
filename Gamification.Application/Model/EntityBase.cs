using System;
using System.Collections.Generic;

namespace Gamification.Application.Model
{
    public interface IEntityBase<TEntity> where TEntity : EntityBase
    {
        void Add(TEntity entity);
        void Remove(Guid id);
        void Update(TEntity entity);
        TEntity GetById(Guid id);
        IList<TEntity> GetAll();
        void SaveChanges();
    }

    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
