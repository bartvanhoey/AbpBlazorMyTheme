using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpBlazorMyTheme.EntityFrameworkCore
{
    public static class AbpBlazorMyThemeDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpBlazorMyTheme(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpBlazorMyThemeConsts.DbTablePrefix + "YourEntities", AbpBlazorMyThemeConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}