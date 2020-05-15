using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0008.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TimestampUtcDirectoryNameProvider"/> implementation of <see cref="ITimestampUtcDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultTimestampUtcDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<ITimestampUtcDirectoryNameProvider, TimestampUtcDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="TimestampUtcDirectoryNameProvider"/> implementation of <see cref="ITimestampUtcDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ITimestampUtcDirectoryNameProvider> AddDefaultTimestampUtcDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<ITimestampUtcDirectoryNameProvider>.New(() => services.AddDefaultTimestampUtcDirectoryNameProvider());
            return serviceAction;
        }
    }
}
