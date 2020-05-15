using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0008.Default;


namespace R5T.D0008.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ITimestampUtcDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddTimestampUtcDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddDefaultTimestampUtcDirectoryNameProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ITimestampUtcDirectoryNameProvider"/> service.
        /// </summary>
        public static ServiceAction<ITimestampUtcDirectoryNameProvider> AddTimestampUtcDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<ITimestampUtcDirectoryNameProvider>.New(() => services.AddTimestampUtcDirectoryNameProvider());
            return serviceAction;
        }
    }
}
