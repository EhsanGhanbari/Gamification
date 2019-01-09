using Gamification.Service.DataModel;

namespace Gamification.Service.Implementing
{
    public interface IDarikService
    {
        ResponseBase Charge(ChargeDarikView chargeDarikView);
    }

    internal class DarikService : IDarikService
    {
        public ResponseBase Charge(ChargeDarikView chargeDarikView)
        {
            throw new System.NotImplementedException();
        }
    }
}
