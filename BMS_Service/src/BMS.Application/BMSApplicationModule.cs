using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BMS.Authorization;

namespace BMS
{
    [DependsOn(
        typeof(BMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
