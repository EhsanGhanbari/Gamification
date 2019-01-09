using System;
using System.Collections.Generic;
using Gamification.Shared;

namespace Gamification.Application.Model
{
    public class Charge : EntityBase
    {
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public ChargeType Type { get; set; }
        public ICollection<User> Users { get; set; } 
    }
}
