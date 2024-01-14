using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class User:AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string  MobileNumber { get; set; }
        public string Address { get; set; }
        public Guid? WalletId { get; set; }
        public virtual Wallet Wallet { get; set; }
        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int? AdminId { get; set; }
        public virtual Admin Admin { get; set; }
        public int? MerchantId { get; set; }
        public virtual Merchant Merchant { get; set; }
        
    }
}
