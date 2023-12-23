using Abp.Authorization;
using BMS.Authorization.Roles;
using BMS.Authorization.Users;

namespace BMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
