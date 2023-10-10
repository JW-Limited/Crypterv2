namespace LILO_Packager.v2.Core.LILO.Interfaces
{
    public interface ILILOUser
    {
        string Email { get; set; }
        string Password { get; set; }
        DateTime RegistrationDate { get; set; }
        string Role { get; set; }
    }
}