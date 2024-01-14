using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class ClientType : AuditableEntity
    {
        
        public string  Title { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
