using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Implementing Admin Class
namespace CampusCoin.Models
{
    public class Admin : AuditableEntity
    {
        public int Id { get; set; }
        public DateTime? HireDate { get; set; }
        public int? ManagerialBranchId { get; set; }
        public virtual ManagerialBranch ManagerialBranch { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
