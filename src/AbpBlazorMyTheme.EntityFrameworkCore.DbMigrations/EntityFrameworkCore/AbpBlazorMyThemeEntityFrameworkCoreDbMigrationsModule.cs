using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpBlazorMyTheme.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpBlazorMyThemeEntityFrameworkCoreModule)
        )]
    public class AbpBlazorMyThemeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpBlazorMyThemeMigrationsDbContext>();
        }
    }
}
