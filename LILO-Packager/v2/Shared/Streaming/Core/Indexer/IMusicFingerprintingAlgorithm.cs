namespace LILO_Packager.v2.Shared.Streaming.Core.Indexer
{
    public interface IMusicFingerprintingAlgorithm
    {
        string GetFingerprint(string filename);
        int IdentifySong(string fingerprint);
    }
}