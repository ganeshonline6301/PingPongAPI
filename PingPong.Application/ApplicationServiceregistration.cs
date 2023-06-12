using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PingPong.Application.MappingProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application
{
    public static class ApplicationServiceregistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection Services)
        {
            Services.AddAutoMapper(typeof(Mapping));
           // Services.AddMediatR(Assembly.GetExecutingAssembly());
             Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
           // Services.AddMediatR(AppDomain.CurrentDomain.Load("PingPong.Application.Features.Player"));

            return Services;
        }
    }
}
