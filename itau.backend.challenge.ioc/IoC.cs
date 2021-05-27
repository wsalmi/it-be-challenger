using Itau.Backend.Challenge.Application.Services;
using Itau.Backend.Challenge.Interfaces.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itau.Backend.Challenge.IoC
{
    public static class IoC
    {
        public static IServiceCollection AddApplicationIoC(this IServiceCollection service)
        {
            service.AddScoped<IPasswordService, PasswordService>();

            return service;
        }
    }
}
