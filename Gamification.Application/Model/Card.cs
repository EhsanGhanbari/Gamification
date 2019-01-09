using System;
using System.Collections.Generic;

namespace Gamification.Application.Model
{
    public class Card : EntityBase
    {
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public ICollection<User> Users { get; set; } 
    }
}
