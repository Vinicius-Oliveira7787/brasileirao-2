using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Brasileirao.Api.Configurations
{
    public static class MvcConfiguration
    {
        public static void AddMvcConfiguration(this IServiceCollection services)
        {
            services = services ?? throw new ArgumentNullException(nameof(services));

            services
                .AddMvc()
                .AddFluentValidation(options =>
                {
                    options.RegisterValidatorsFromAssemblyContaining<Startup>();
                });
        }
    }
}
