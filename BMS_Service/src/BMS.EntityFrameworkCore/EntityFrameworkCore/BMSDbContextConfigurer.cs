using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BMS.EntityFrameworkCore
{
    public static class BMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
