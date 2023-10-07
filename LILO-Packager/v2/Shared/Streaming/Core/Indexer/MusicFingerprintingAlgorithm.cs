using System.Text;

namespace LILO_Packager.v2.Shared.Streaming.Core.Indexer
{
    public class MusicFingerprintingAlgorithm : IMusicFingerprintingAlgorithm
    {
        // The parameters of the algorithm.
        private int _windowSize;
        private int _hopSize;
        private int _peakThreshold;

        // The database of known song fingerprints.
        private Dictionary<int, string> _songFingerprints;

        public MusicFingerprintingAlgorithm(int windowSize = 1024, int hopSize = 512, int peakThreshold = 100)
        {
            _windowSize = windowSize;
            _hopSize = hopSize;
            _peakThreshold = peakThreshold;

            _songFingerprints = new Dictionary<int, string>();
        }

        // Extracts the fingerprint of a song file.
        public string GetFingerprint(string filename)
        {
            // Read the audio data from the song file.
            byte[] audioData = File.ReadAllBytes(filename);

            // Create a spectrogram of the audio data.
            Spectrogram spectrogram = new Spectrogram(audioData, _windowSize, _hopSize);

            // Find the peaks in the spectrogram.
            List<Peak> peaks = spectrogram.FindPeaks(_peakThreshold);

            // Generate the fingerprint from the peaks.
            string fingerprint = GenerateFingerprint(peaks);

            return fingerprint;
        }

        // Identifies a song based on its fingerprint.
        public int IdentifySong(string fingerprint)
        {
            // Compare the fingerprint to the database of known song fingerprints.
            foreach (var songFingerprint in _songFingerprints)
            {
                if (fingerprint == songFingerprint.Value)
                {
                    return songFingerprint.Key;
                }
            }

            // The fingerprint was not found in the database.
            return -1;
        }

        private string GenerateFingerprint(List<Peak> peaks)
        {
            peaks.Sort((p1, p2) => p1.Frequency.CompareTo(p2.Frequency));

            StringBuilder fingerprintStringBuilder = new StringBuilder();

            foreach (var peak in peaks)
            {
                fingerprintStringBuilder.Append($"{peak.Frequency},{peak.Magnitude};");
            }

            return fingerprintStringBuilder.ToString();
        }
    }


}
