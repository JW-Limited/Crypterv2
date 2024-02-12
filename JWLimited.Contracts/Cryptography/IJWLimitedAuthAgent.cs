namespace JWLimited.Contracts.Cryptography
{
    public interface IJWLimitedAuthAgent
    {
        bool HasAccessRights { get; }
        bool IsAuthenticated { get; }
        IJWLimitedApplication ProgramDetails { get; }
        string ProgrammID { get; }
    }
}
