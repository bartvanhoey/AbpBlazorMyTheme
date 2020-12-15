using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpBlazorMyTheme.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class AbpBlazorMyThemeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpBlazorMyTheme";
    }
}
