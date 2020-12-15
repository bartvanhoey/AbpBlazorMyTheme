using AbpBlazorMyTheme.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpBlazorMyTheme.Blazor
{
    public abstract class AbpBlazorMyThemeComponentBase : AbpComponentBase
    {
        protected AbpBlazorMyThemeComponentBase()
        {
            LocalizationResource = typeof(AbpBlazorMyThemeResource);
        }
    }
}
