using Gamification.Application.Model;

namespace Gamification.Application.BusinessTask
{
    public interface ICardBusiness : IEntityBase<Card>
    {
    }

    internal class CardBusiness : EntityBaseBusiness<Card>, ICardBusiness
    {
    }
}
