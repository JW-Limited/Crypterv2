namespace LILO_Packager.v2.streaming.MusikPlayer.Core.Indexer
{
    public interface IMusicFingerprintingAlgorithm
    {
        string GetFingerprint(string filename);
        int IdentifySong(string fingerprint);
    }
}