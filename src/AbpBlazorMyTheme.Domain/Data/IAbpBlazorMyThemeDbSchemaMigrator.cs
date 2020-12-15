using System.Threading.Tasks;

namespace AbpBlazorMyTheme.Data
{
    public interface IAbpBlazorMyThemeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
