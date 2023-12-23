using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BMS.Authorization.Roles;
using BMS.Authorization.Users;
using BMS.MultiTenancy;

namespace BMS.EntityFrameworkCore
{
    public class BMSDbContext : AbpZeroDbContext<Tenant, Role, User, BMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BMSDbContext(DbContextOptions<BMSDbContext> options)
            : base(options)
        {
        }
    }
}
