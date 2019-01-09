using Gamification.Application.Model;

namespace Gamification.Application.BusinessTask
{
    public interface IMessageBusiness : IEntityBase<Message>
    {
    }

    internal class MessageBusiness : EntityBaseBusiness<Message>, IMessageBusiness
    {
    }
}
