using Volo.Abp.Bundling;

namespace AbpBlazorMyTheme.Blazor
{
    public class AbpBlazorMyThemeBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css");
        }
    }
}
