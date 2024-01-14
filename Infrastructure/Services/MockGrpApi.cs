// <copyright file="MockGrpApi.cs" company="PNU">
// Copyright (c) PNU. All rights reserved.
// </copyright>

namespace CampusCoin.Infrastructure.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using CampusCoin.Common.Options;
    using CampusCoin.Common.Models;
    using Refit;

    public class MockMIUApi : IMIUApi
    {
        private readonly MIUOptions _miuOptions;
        private readonly IEnumerable<EmployeeInfoDto> _employees;
        private readonly IEnumerable<AcademicEmployeeInfoDto> _academicEmployees;
        public MockMIUApi(IOptionsMonitor<MIUOptions> miuOptions)
        {
            this._miuOptions = miuOptions.CurrentValue;
            this._employees = this._miuOptions.MockedDataContent.Employees;
            this._academicEmployees = this._miuOptions.MockedDataContent.AcademicEmployees;
        }
        public Task<IApiResponse<EmployeeInfoDto>> GetEmployeeInfo(string userId)
        {
            return Task<IApiResponse<EmployeeInfoDto>>.Factory.StartNew(() =>
            {
                var dto = new EmployeeInfoDto();
                var response = new HttpResponseMessage();
                if (this._employees.SingleOrDefault(x => x.UserId == userId) != default)
                    dto = this._employees.Single(x => x.UserId == userId);
                else
                {
                    dto = null;
                    response = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                }

                return new ApiResponse<EmployeeInfoDto>(response, dto, new RefitSettings());
            });
        }

        public Task<IApiResponse<AcademicEmployeeInfoDto>> GetAcademicEmployeeInfo(string userId)
        {
            return Task<IApiResponse<AcademicEmployeeInfoDto>>.Factory.StartNew(() =>
            {
                var dto = new AcademicEmployeeInfoDto();
                var response = new HttpResponseMessage();
                if (this._academicEmployees.SingleOrDefault(x => x.__UserId == userId) != default)
                    dto = this._academicEmployees.Single(x => x.__UserId == userId);
                else
                {
                    dto = null;
                    response = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                }

                return new ApiResponse<AcademicEmployeeInfoDto>(response, dto, new RefitSettings());
            });
        }

    }
}
