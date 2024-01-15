using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class TransferTransaction : AuditableEntity
    {
        
        public Guid? ToWalletId { get; set; }
        public int Id { get; set; }
        public virtual Wallet ToWallet { get; set; }
        public Guid? FromWalletId { get; set; }
        public double? Amount { get; set; }
    }
}
