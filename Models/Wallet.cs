using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public double? Ballance { get; set; }
        public bool? IsActive { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public ICollection<DepositTransaction> DepositTransactions { get; set; }
        public ICollection<TransferTransaction> TransferTransactions { get; set; }
        public ICollection<PaymentRequest> PaymentRequests { get; set; }
    }
}
