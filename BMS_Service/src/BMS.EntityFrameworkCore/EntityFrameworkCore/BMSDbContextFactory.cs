using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BMS.Configuration;
using BMS.Web;

namespace BMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BMSDbContextFactory : IDesignTimeDbContextFactory<BMSDbContext>
    {
        public BMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BMSConsts.ConnectionStringName));

            return new BMSDbContext(builder.Options);
        }
    }
}
