namespace LILO_Packager.v2.Core.LILO.Interfaces
{
    public interface ILILOLicenseManager
    {
        Task<bool> LogInAsync(string username, string password);
        Task<bool> ReadLicensesAsync(string username);
        Task<bool> SaveUserToUser(params string[] userDetail);
    }
}