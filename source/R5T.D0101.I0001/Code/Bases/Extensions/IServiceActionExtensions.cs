using System;

using R5T.D0101.I001;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0101.I0001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="HardCodedProjectRepositoryFilePathsProvider"/> implementation of <see cref="IProjectRepositoryFilePathsProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProjectRepositoryFilePathsProvider> AddHardCodedProjectRepositoryFilePathsProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IProjectRepositoryFilePathsProvider>(services => services.AddHardCodedProjectRepositoryFilePathsProvider());
            return serviceAction;
        }
    }
}
