using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BMS.Controllers
{
    public abstract class BMSControllerBase: AbpController
    {
        protected BMSControllerBase()
        {
            LocalizationSourceName = BMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
