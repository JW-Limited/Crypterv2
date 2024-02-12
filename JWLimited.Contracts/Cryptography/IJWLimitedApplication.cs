namespace JWLimited
{
    public interface IJWLimitedApplication
    {
        string Executable { get; set; }
        string Name { get; set; }
        string ProjectLink { get; set; }
        string RealName { get; set; }
    }
}