using Gamification.Application.Model;

namespace Gamification.Application.Mapping
{
    internal class UserMap : EntityBaseMap<User>
    {
        protected UserMap()
        {
            Table("'User'");
            Not.LazyLoad();
            Map(u => u.Mobile).Length(15).Not.Nullable();
            Map(u => u.Email).Length(70).Not.Nullable();
            Map(u => u.Password).Length(18).Not.Nullable();
            Map(u => u.IsBlocked);
            Map(u => u.Level).CustomType<int>();
            References(u => u.Profile);
        }
    }

    internal class ProfileMap : EntityBaseMap<Profile>
    {
        protected ProfileMap()
        {
            Table("'Profile'");
            Not.LazyLoad();
            Map(p => p.NickName).Length(40).Not.Nullable();
            Map(p => p.FirstName).Length(40).Not.Nullable();
            Map(p => p.LastName).Length(40).Not.Nullable();
            HasMany(p => p.Statuses);
        }
    }

    internal class StatusMap : EntityBaseMap<Status>
    {
        protected StatusMap()
        {
            Table("Status");
            Not.LazyLoad();
        }
    }
}
