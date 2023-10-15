namespace LILO_Packager.v2.Core.Interfaces
{
    public interface ICrypterv2Version
    {
        string Edition { get; set; }
        bool IsNewer { get; set; }
        int Major { get; set; }
        int Minor { get; set; }
        int Patch { get; set; }

        string ToString();
    }
}