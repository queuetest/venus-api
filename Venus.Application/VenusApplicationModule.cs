using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Venus.Authorization;

namespace Venus
{
    [DependsOn(
        typeof(VenusCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VenusApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VenusAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VenusApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
