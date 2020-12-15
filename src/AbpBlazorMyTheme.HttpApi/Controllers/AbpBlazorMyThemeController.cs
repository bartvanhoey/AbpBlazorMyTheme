using AbpBlazorMyTheme.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpBlazorMyTheme.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpBlazorMyThemeController : AbpController
    {
        protected AbpBlazorMyThemeController()
        {
            LocalizationResource = typeof(AbpBlazorMyThemeResource);
        }
    }
}