using CampusCoin.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//implemented front page of deposit wallet
namespace CampusCoin.ViewModels
{
    public class DepositWalletViewModel
    {
        public int DepositId { get; set; }
        public string UserSSN { get; set; }
        public int? CreditTransactionTypeId { get; set; }
        public List<DepositTransactionType> CreditTransactionTypes { get; set; }
        public int? ManagerialBranchId { get; set; }
        public string BankAccountNumber { get; set; }

        [Required]
        public double? Amount { get; set; }
      
        public List<ManagerialBranch> ManagerialBranchs { get; set; }

    }
}
