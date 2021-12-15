using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0101.I001;
using R5T.T0063;


namespace R5T.D0101.I0001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="HardCodedProjectRepositoryFilePathsProvider"/> implementation of <see cref="IProjectRepositoryFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddHardCodedProjectRepositoryFilePathsProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProjectRepositoryFilePathsProvider, HardCodedProjectRepositoryFilePathsProvider>();

            return services;
        }
    }
}
