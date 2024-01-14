// <copyright file="DependencyInjection.cs" company="PNU">
// Copyright (c) PNU. All rights reserved.
// </copyright>

namespace CampusCoin
{
    using System;
    using System.Net.Http.Headers;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using CampusCoin.Common.Options;
    using Refit;
    using CampusCoin.Infrastructure.Services;
    using CampusCoin.Models;
    using CampusCoin.Common.Interfaces;
    //Adding DBContext to AppContext
    public static class DependencyInjection
    {
        public static IConfiguration _configuration;

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            _configuration = configuration;

            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(
                 _configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            //var grpOptions = _configuration.GetSection(MIUOptions.MIU).Get<MIUOptions>();

            //if (grpOptions.IsMocked)
            //{
            //    services.AddScoped<IMIUApi, MockMIUApi>();
            //}
            //else
            //{
               
            //}
            return services;
        }
    }
}
