using FluentNHibernate.Mapping;
using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal abstract class EntityBaseMap<TEntity> : ClassMap<TEntity> where TEntity : EntityBase
    {
        protected EntityBaseMap()
        {
            Not.LazyLoad();
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(e => e.CreationTime).Not.Nullable();
        }
    }
}
