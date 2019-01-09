using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class CardMap : EntityBaseMap<Card>
    {
        protected CardMap()
        {
            Table("Card");
            Not.LazyLoad();
        }
    }
}
