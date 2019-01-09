using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Gamification.Application.Mapping;
using NHibernate;
using System.Collections;
using System.Configuration;
using System.Web;

namespace Gamification.Application
{
    public static class SessionFactory
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["GamificationConnection"].ToString(); }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(c => c.FromConnectionStringWithKey("GamificationConnection")))
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssemblyOf<BillMap>();
                    m.FluentMappings.AddFromAssemblyOf<CardMap>();
                    m.FluentMappings.AddFromAssemblyOf<ChargeMap>();
                    m.FluentMappings.AddFromAssemblyOf<DarikMap>();
                    m.FluentMappings.AddFromAssemblyOf<GameMap>();
                    m.FluentMappings.AddFromAssemblyOf<MessageMap>();
                    m.FluentMappings.AddFromAssemblyOf<NotificationMap>();
                    m.FluentMappings.AddFromAssemblyOf<TaskMap>();
                    m.FluentMappings.AddFromAssemblyOf<UserMap>();
                }
            ).BuildSessionFactory();
        }

        private static ISession GetNewSession()
        {
            return CreateSessionFactory().OpenSession();
        }

        public static ISession GetCurrentSession()
        {
            var sessionStorageContainer = SessionStorageFactory.GetStorageContainer();

            var currentSession = sessionStorageContainer.GetCurrentSession();

            if (currentSession == null)
            {
                currentSession = GetNewSession();
                sessionStorageContainer.Store(currentSession);
            }

            return currentSession;
        }
    }

    public static class SessionStorageFactory
    {
        private static ISessionStorageContainer _nhSessionStorageContainer;

        public static ISessionStorageContainer GetStorageContainer()
        {
            if (_nhSessionStorageContainer == null)
            {
                if (HttpContext.Current == null)
                    _nhSessionStorageContainer = new ThreadSessionStorageContainer();
                else
                    _nhSessionStorageContainer = new HttpSessionContainer();
            }

            return _nhSessionStorageContainer;
        }
    }

    public class HttpSessionContainer : ISessionStorageContainer
    {
        private const string SessionKey = "NHSession";

        public ISession GetCurrentSession()
        {
            ISession nhSession = null;

            if (HttpContext.Current.Items.Contains(SessionKey))
                nhSession = (ISession)HttpContext.Current.Items[SessionKey];

            return nhSession;
        }

        public void Store(ISession session)
        {
            if (HttpContext.Current.Items.Contains(SessionKey))
                HttpContext.Current.Items[SessionKey] = session;
            else
                HttpContext.Current.Items.Add(SessionKey, session);
        }
    }

    public interface ISessionStorageContainer
    {
        ISession GetCurrentSession();
        void Store(ISession session);
    }

    public class ThreadSessionStorageContainer : ISessionStorageContainer
    {
        private static readonly Hashtable Sessions = new Hashtable();

        public ISession GetCurrentSession()
        {
            ISession nhSession = null;

            if (Sessions.Contains(GetThreadName()))
                nhSession = (ISession)Sessions[GetThreadName()];

            return nhSession;
        }

        public void Store(ISession session)
        {
            if (Sessions.Contains(GetThreadName()))
                Sessions[GetThreadName()] = session;
            else
                Sessions.Add(GetThreadName(), session);
        }

        private static string GetThreadName()
        {
            return "";
        }
    }
}
