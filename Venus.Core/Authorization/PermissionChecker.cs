using Abp.Authorization;
using Venus.Authorization.Roles;
using Venus.Authorization.Users;

namespace Venus.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
