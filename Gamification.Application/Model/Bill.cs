using System;
using System.Collections.Generic;
using Gamification.Shared;

namespace Gamification.Application.Model
{
    public class Bill : EntityBase
    {
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public BillType Type { get; set; }
        public string BillID { get; set; }
        public string PaymentID { get; set; }
        public ICollection<User> Users { get; set; } 
    }
}
