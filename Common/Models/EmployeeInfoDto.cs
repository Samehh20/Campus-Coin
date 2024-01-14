// <copyright file="EmployeeInfoDto.cs" company="PNU">
// Copyright (c) PNU. All rights reserved.
// </copyright>

namespace CampusCoin.Common.Models
{
    using System;
    using System.Collections.Generic;
    
    public class EmployeeInfoDto
    {
        public string UserId { get; set; }
        public string IdentityNumber { get; set; }
        public string Nationality { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullNameEn { get; set; }
        public string FullNameAr { get; set; }
        public string CollegeName { get; set; }
        public string DepartmentName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
