using System;
using Gamification.Application.BusinessTask;
using Gamification.Service.DataModel;

namespace Gamification.Service.Implementing
{
    public interface IBillService
    {
        ResponseBase PayBill(BillView waterBillView);
        ResponseBase GetPaymentHistory(Guid userId);
    }

    internal class BillService : IBillService
    {
        private readonly IBillBusiness _billBusiness;

        public BillService(IBillBusiness billBusiness)
        {
            _billBusiness = billBusiness;
        }

        public ResponseBase PayBill(BillView waterBillView)
        {
            throw new System.NotImplementedException();
        }

        public ResponseBase GetPaymentHistory(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
