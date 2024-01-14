using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class DepositTransaction : AuditableEntity
    {
        public int Id { get; set; }
        public Guid? WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public double? Amount { get; set; }
        public int? DepositTransactionTypeId { get; set; }
        public DepositTransactionType DepositTransactionType { get; set; }
        public int? ManagerialBranchId { get; set; }
        public virtual ManagerialBranch ManagerialBranch { get; set; }
        public string BankAccountNumber { get; set; }
       


    }
}
