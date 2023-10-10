using LILO_Packager.v2.Core.LILO.Types;

namespace LILO_Packager.v2.Core.LILO.Interfaces
{
    public interface ILILOUserRole
    {
        UserRole GetHighestUserRole();
        List<Permission> GetPermissions(int id);
        bool HasPermission(Permission permission);
    }
}