using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Gamification.Application.BusinessTask;

namespace Gamification.Application
{
    public class ApplicationInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IBillBusiness>().ImplementedBy<BillBusiness>());
            container.Register(Component.For<ICardBusiness>().ImplementedBy<CardBusiness>());
            container.Register(Component.For<IChargeBusiness>().ImplementedBy<ChargeBusiness>());
            container.Register(Component.For<ICharityBusiness>().ImplementedBy<CharityBusiness>());
            container.Register(Component.For<IDarikBusiness>().ImplementedBy<DarikBusiness>());
            container.Register(Component.For<IGameBusiness>().ImplementedBy<GameBusiness>());
            container.Register(Component.For<IMessageBusiness>().ImplementedBy<MessageBusiness>());
            container.Register(Component.For<INotificationBusiness>().ImplementedBy<NotificationBusiness>());
            container.Register(Component.For<ITaskBusiness>().ImplementedBy<TaskBusiness>());
            container.Register(Component.For<IUserBusiness>().ImplementedBy<UserBusiness>());
        }
    }
}
