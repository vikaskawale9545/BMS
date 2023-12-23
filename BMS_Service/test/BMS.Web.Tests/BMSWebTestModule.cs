using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BMS.EntityFrameworkCore;
using BMS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BMS.Web.Tests
{
    [DependsOn(
        typeof(BMSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BMSWebTestModule : AbpModule
    {
        public BMSWebTestModule(BMSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BMSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BMSWebMvcModule).Assembly);
        }
    }
}