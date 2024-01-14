using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//implemented class DepositTransactionType
namespace CampusCoin.Models
{
    public class DepositTransactionType : AuditableEntity
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
    }
}
