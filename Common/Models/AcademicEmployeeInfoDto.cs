// <copyright file="AcademicEmployeeInfoDto.cs" company="PNU">
// Copyright (c) PNU. All rights reserved.
// </copyright>

namespace  CampusCoin.Common.Models
{
    using System;

    public partial class AcademicEmployeeInfoDto
    {
        public string __UserId { get; set; }

        public string IdentityNumber { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public string LastName { get; set; }

        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }

        public string MobileNumber { get; set; }

        public string PhoneExtensionNumber { get; set; }

        public DateTime? GDateOfBirth { get; set; }

        public string Nationality { get; set; }

        public string CollegeName { get; set; }

        public string DepartmentName { get; set; }
    }
}