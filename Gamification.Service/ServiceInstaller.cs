using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Gamification.Application;
using Gamification.Service.Implementing;

namespace Gamification.Service
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Install(new ApplicationInstaller());
            container.Register(Component.For<IBillService>().ImplementedBy<BillService>());
            container.Register(Component.For<ICardService>().ImplementedBy<CardService>());
            container.Register(Component.For<IChargeService>().ImplementedBy<ChargeService>());
            container.Register(Component.For<ICharityService>().ImplementedBy<CharityService>());
            container.Register(Component.For<IDarikService>().ImplementedBy<DarikService>());
            container.Register(Component.For<IGameService>().ImplementedBy<GameService>());
            container.Register(Component.For<IMessageService>().ImplementedBy<MessageService>());
            container.Register(Component.For<INotificationService>().ImplementedBy<NotificationService>());
            container.Register(Component.For<ITaskService>().ImplementedBy<TaskService>());
            container.Register(Component.For<IUserService>().ImplementedBy<UserService>());
        }
    }
}
