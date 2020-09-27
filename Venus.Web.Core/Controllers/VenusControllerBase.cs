using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Venus.Controllers
{
    public abstract class VenusControllerBase: AbpController
    {
        protected VenusControllerBase()
        {
            LocalizationSourceName = VenusConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
