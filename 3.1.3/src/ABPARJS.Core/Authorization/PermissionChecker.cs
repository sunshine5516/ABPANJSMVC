using Abp.Authorization;
using ABPARJS.Authorization.Roles;
using ABPARJS.Authorization.Users;

namespace ABPARJS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
