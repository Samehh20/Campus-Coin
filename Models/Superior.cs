﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class Superior
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}