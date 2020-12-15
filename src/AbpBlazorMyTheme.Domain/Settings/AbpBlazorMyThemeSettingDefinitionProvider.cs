using Volo.Abp.Settings;

namespace AbpBlazorMyTheme.Settings
{
    public class AbpBlazorMyThemeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpBlazorMyThemeSettings.MySetting1));
        }
    }
}
