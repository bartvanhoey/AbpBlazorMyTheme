using AbpBlazorMyTheme.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpBlazorMyTheme.Permissions
{
    public class AbpBlazorMyThemePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpBlazorMyThemePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpBlazorMyThemePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpBlazorMyThemeResource>(name);
        }
    }
}
