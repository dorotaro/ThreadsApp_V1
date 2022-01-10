using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Clients;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public static class PersistenceExtension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddSqlClients(configuration)
                .AddRepositories();
        }

        private static IServiceCollection AddSqlClients(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("ConnectionStrings")["SqlConnectionString"];

            return services
                .AddTransient<ISqlClient>(_ => new SqlClient(connectionString));
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                    .AddSingleton<IThreadsRepository, ThreadsRepository>();
        }

        
    }
}
