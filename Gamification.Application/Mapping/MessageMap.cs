using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class MessageMap : EntityBaseMap<Message>
    {
        protected MessageMap()
        {
            Table("Message");
            Not.LazyLoad();
            Map(t => t.Body).Length(500).Not.Nullable();
            Map(t => t.IsRead);
            Map(t => t.IsDisabledForAlert);
        }
    }
}
