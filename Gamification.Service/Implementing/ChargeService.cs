using System;
using Gamification.Application.BusinessTask;
using Gamification.Service.DataModel;
using Gamification.Service.Messaging;
using log4net;

namespace Gamification.Service.Implementing
{
    public interface IChargeService
    {
        ChargeResponse ChargeMci(ChargeView chargeView);
        ChargeResponse ChargeIrancell(ChargeView chargeView);
        ChargeResponse ChargeRightel(ChargeView chargeView);
    }

    internal class ChargeService : IChargeService
    {
        private readonly IChargeBusiness _chargeBusiness;
        private readonly ILog _log;

        public ChargeService(IChargeBusiness chargeBusiness)
        {
            _chargeBusiness = chargeBusiness;
        }

        public ChargeResponse ChargeMci(ChargeView chargeView)
        {
            var response = new ChargeResponse();

            try
            {
                var charge = chargeView.ToModel();
                _chargeBusiness.Add(charge);
                _chargeBusiness.SaveChanges();
                response.Suceeded = true;
            }
            catch (Exception exception)
            {
                response.Suceeded = false;
                response.Message = "";
            }

            return response;
        }

        public ChargeResponse ChargeIrancell(ChargeView chargeView)
        {
            var response = new ChargeResponse();

            try
            {
                var charge = chargeView.ToModel();
                _chargeBusiness.Add(charge);
                _chargeBusiness.SaveChanges();
                response.Suceeded = true;
            }
            catch (Exception exception)
            {
                response.Suceeded = false;
                response.Message = "";
            }

            return response;
        }

        public ChargeResponse ChargeRightel(ChargeView chargeView)
        {
            var response = new ChargeResponse();

            try
            {
                var charge = chargeView.ToModel();
                _chargeBusiness.Add(charge);
                _chargeBusiness.SaveChanges();
                response.Suceeded = true;
            }
            catch (Exception exception)
            {
                response.Suceeded = false;
                response.Message = "";
            }

            return response;
        }
    }
}
