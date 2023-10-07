namespace LILO_Packager.v2.Shared.Streaming.Core.Indexer
{
    public interface IComplex
    {
        double Imaginary { get; set; }
        double Real { get; set; }

        string ToString();
    }
}