using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class DarikMap : EntityBaseMap<Darik>
    {
        protected DarikMap()
        {
            Table("Darik");
            Not.LazyLoad();
        }
    }
}
