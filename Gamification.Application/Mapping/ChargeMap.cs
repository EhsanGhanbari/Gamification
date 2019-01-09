using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class ChargeMap : EntityBaseMap<Charge>
    {
        protected ChargeMap()
        {
            Table("Charge");
            Not.LazyLoad();
        }
    }
}
