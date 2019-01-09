using Gamification.Application.Model;

namespace Gamification.Application.BusinessTask
{
    public interface ICharityBusiness : IEntityBase<Charity>
    {
    }

    internal class CharityBusiness : EntityBaseBusiness<Charity>, ICharityBusiness
    {
    }
}
