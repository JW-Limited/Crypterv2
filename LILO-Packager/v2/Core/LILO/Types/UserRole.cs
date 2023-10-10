using LILO_Packager.v2.Core.LILO.Interfaces;

namespace LILO_Packager.v2.Core.LILO.Types
{
    public class UserRole : ILILOUserRole
    {
        private readonly byte _permissions;

        public UserRole(bool canReadPasswordEntry, bool canWritePasswordEntry, bool canDeletePasswordEntry)
        {
            _permissions = (byte)((canReadPasswordEntry ? 1 : 0) | (canWritePasswordEntry ? 2 : 0) | (canDeletePasswordEntry ? 4 : 0));
        }

        public bool HasPermission(Permission permission)
        {
            return (_permissions & 1 << (int)permission) != 0;
        }

        public List<Permission> GetPermissions(int id)
        {
            List<Permission> permissions = new List<Permission>();

            for (int i = 0; i < (int)Permission.DeletePasswordEntry; i++)
            {
                if (HasPermission((Permission)i))
                {
                    permissions.Add((Permission)i);
                }
            }

            return permissions;
        }

        public UserRole GetHighestUserRole()
        {
            UserRole highestUserRole = this;

            if (_permissions < Admin._permissions)
            {
                highestUserRole = Admin;
            }

            if (_permissions < SuperAdmin._permissions)
            {
                highestUserRole = SuperAdmin;
            }

            return highestUserRole;
        }

        public static UserRole User => new UserRole(true, true, false);
        public static UserRole Admin => new UserRole(true, true, true);
        public static UserRole SuperAdmin => new UserRole(true, true, true);
    }

}
