// <copyright file="IGrpApi.cs" company="PNU">
// Copyright (c) PNU. All rights reserved.
// </copyright>

namespace CampusCoin.Infrastructure.Services
{
    
    using System.Threading.Tasks;
    using CampusCoin.Common.Models;
    using Refit;
    public interface IMIUApi
    {
        [Get("/grp/employees/{userId}")]
        Task<IApiResponse<EmployeeInfoDto>> GetEmployeeInfo(string userId);

        // mapped to the new beta-version of academic supporting any legacy implemented academic details.
        [Get("/grp/employees/{userId}/academic2")]
        Task<IApiResponse<AcademicEmployeeInfoDto>> GetAcademicEmployeeInfo(string userId);
        
    }
}
