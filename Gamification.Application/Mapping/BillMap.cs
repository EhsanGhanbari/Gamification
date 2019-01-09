using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class BillMap : EntityBaseMap<Bill>
    {
        protected BillMap()
        {
            Table("Bill");
            Not.LazyLoad();

        }
    }
}
