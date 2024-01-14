using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class Merchant : AuditableEntity
    {
        public int Id { get; set; }
        public string CommercialName { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public ICollection<MerchantBranch> MerchantBranchs { get; set; }
    }
}
