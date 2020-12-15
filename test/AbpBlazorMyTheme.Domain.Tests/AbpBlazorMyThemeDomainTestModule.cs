using AbpBlazorMyTheme.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpBlazorMyTheme
{
    [DependsOn(
        typeof(AbpBlazorMyThemeEntityFrameworkCoreTestModule)
        )]
    public class AbpBlazorMyThemeDomainTestModule : AbpModule
    {

    }
}