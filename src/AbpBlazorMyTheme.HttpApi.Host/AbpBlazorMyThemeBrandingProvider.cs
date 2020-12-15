using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpBlazorMyTheme
{
    [Dependency(ReplaceServices = true)]
    public class AbpBlazorMyThemeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpBlazorMyTheme";
    }
}
