using Gamification.Application.Model;

namespace Gamification.Application.BusinessTask
{
    public interface IBillBusiness : IEntityBase<Bill>
    {
    }

    internal class BillBusiness : EntityBaseBusiness<Bill>, IBillBusiness
    {
    }
}
