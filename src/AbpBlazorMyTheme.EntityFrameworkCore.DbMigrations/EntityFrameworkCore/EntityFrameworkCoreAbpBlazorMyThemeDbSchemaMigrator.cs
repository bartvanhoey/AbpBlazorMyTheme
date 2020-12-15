using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpBlazorMyTheme.Data;
using Volo.Abp.DependencyInjection;

namespace AbpBlazorMyTheme.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpBlazorMyThemeDbSchemaMigrator
        : IAbpBlazorMyThemeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpBlazorMyThemeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpBlazorMyThemeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpBlazorMyThemeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}