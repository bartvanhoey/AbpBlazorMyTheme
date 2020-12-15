using AbpBlazorMyTheme.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpBlazorMyTheme.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpBlazorMyThemeEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpBlazorMyThemeApplicationContractsModule)
        )]
    public class AbpBlazorMyThemeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
