using Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Configuration;

namespace Domain.ServiceExtensions
{
    public static class ServiceExtensions //dependency injection takes place here
    {
		public static IServiceCollection AddDomain(this IServiceCollection service, IConfiguration configuration)
		{
			return service
				.AddServices()
				.AddPersistenceServices(configuration);
		}
		private static IServiceCollection AddServices(this IServiceCollection service)
		{
			return service
				.AddSingleton<IThreadsService, ThreadsService>();
		}

		private static IServiceCollection AddPersistenceServices(this IServiceCollection service, IConfiguration configuration)
		{
			return service.AddPersistence(configuration);
		}
	}
}
