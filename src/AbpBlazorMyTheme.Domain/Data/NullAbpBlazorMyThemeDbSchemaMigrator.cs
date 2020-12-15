using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpBlazorMyTheme.Data
{
    /* This is used if database provider does't define
     * IAbpBlazorMyThemeDbSchemaMigrator implementation.
     */
    public class NullAbpBlazorMyThemeDbSchemaMigrator : IAbpBlazorMyThemeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}