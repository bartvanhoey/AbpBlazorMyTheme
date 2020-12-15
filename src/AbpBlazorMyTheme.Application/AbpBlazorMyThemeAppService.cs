using System;
using System.Collections.Generic;
using System.Text;
using AbpBlazorMyTheme.Localization;
using Volo.Abp.Application.Services;

namespace AbpBlazorMyTheme
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpBlazorMyThemeAppService : ApplicationService
    {
        protected AbpBlazorMyThemeAppService()
        {
            LocalizationResource = typeof(AbpBlazorMyThemeResource);
        }
    }
}
