﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//implemted auditable Entity
namespace CampusCoin.Models
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
