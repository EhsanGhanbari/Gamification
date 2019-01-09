using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class GameMap : EntityBaseMap<Game>
    {
        protected GameMap()
        {
            Table("Game");
            Not.LazyLoad();
        }
    }
}
