using Gamification.Application.Model;

namespace Gamification.Application.BusinessTask
{
    public interface IDarikBusiness : IEntityBase<Darik>
    {
    }

    internal class DarikBusiness : EntityBaseBusiness<Darik>, IDarikBusiness
    {
    }
}
