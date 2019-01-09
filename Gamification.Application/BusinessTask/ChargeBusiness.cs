using Gamification.Application.Model;

namespace Gamification.Application.BusinessTask
{
    public interface IChargeBusiness : IEntityBase<Charge>
    {
    }

    internal class ChargeBusiness : EntityBaseBusiness<Charge>, IChargeBusiness
    {
    }
}
