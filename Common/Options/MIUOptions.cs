// <copyright file="GrpOptions.cs" company="PNU">
// Copyright (c) PNU. All rights reserved.
// </copyright>

namespace CampusCoin.Common.Options
{
    using CampusCoin.Common.Models;
    using System.Collections.Generic;

    public class MIUOptions
    {
        public const string MIU = "MIU";
        public bool IsMocked { get; set; }
        public MockedData MockedDataContent { get; set; }
        public class MockedData
        {
            public IEnumerable<EmployeeInfoDto> Employees { get; set; }
            public IEnumerable<AcademicEmployeeInfoDto> AcademicEmployees { get; set; }
        }
    }
}