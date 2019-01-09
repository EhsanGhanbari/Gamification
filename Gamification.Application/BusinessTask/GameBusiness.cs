using Gamification.Application.Model;

namespace Gamification.Application.BusinessTask
{
    public interface IGameBusiness : IEntityBase<Game>
    {
    }

    internal class GameBusiness : EntityBaseBusiness<Game>, IGameBusiness
    {
    }
}
