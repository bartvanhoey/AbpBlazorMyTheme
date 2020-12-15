using Volo.Abp.Modularity;

namespace AbpBlazorMyTheme
{
    [DependsOn(
        typeof(AbpBlazorMyThemeApplicationModule),
        typeof(AbpBlazorMyThemeDomainTestModule)
        )]
    public class AbpBlazorMyThemeApplicationTestModule : AbpModule
    {

    }
}