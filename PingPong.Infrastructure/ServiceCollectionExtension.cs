using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Infrastructure
{
    public static class ServiceCollectionExtension 
    {
        public static IServiceCollection AddInfrastruceServices(this IServiceCollection services, IConfiguration configuration) 
        {
            return services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultSQLConnection")));
        }
    }
}
