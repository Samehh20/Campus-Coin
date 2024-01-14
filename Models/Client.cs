using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class Client : AuditableEntity
    {
        public int Id { get; set; }
        public int? ClientTypeId { get; set; }
        public virtual ClientType ClientType { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        
    }
}
