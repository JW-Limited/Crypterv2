namespace LILO_Packager.v2.Core.LILO.Interfaces
{
    public interface ILILOUser
    {
        string Email { get; set; }
        string Name { get; }
        string Password { get; set; }
        DateTime RegistrationDate { get; set; }
        string Role { get; set; }
        void LogOff();
        Task<ILILOUser> Login(string email, string password);
    }
}