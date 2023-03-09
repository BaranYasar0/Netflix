using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Netflix.Api.Application.Features.Commands.Movies.CreateMovie;
using Netflix.Api.Application.Features.Profiles.Movie;
using Netflix.Api.Application.Features.Rules;
using Netflix.Api.Application.Pipelines;
using Netflix.Api.Application.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Extensions
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehaviour<,>));


            services.AddScoped<MovieBusinessRules>();
            services.AddScoped<MovieProfile>();




            return services;
        }
    }
}
