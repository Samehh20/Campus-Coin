using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class ManagerialBranch
    {
        public int Id { get; set; }
      
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public ICollection<Admin> Admins { get; set; }
    }
}
