namespace LILO_Packager.v2.Shared.Streaming.Core.Indexer
{
    public class Spectrogram
    {
        private double[][] _data;
        private int _windowSize;
        private int _hopSize;

        public Spectrogram(byte[] audioData, int windowSize, int hopSize)
        {
            _windowSize = windowSize;
            _hopSize = hopSize;

            // Create a Fourier transform object.
            FourierTransform fourierTransform = new FourierTransform();

            // Compute the spectrogram of the audio data.
            _data = fourierTransform.ComputeSpectrogram(audioData, windowSize, hopSize);
        }

        public List<Peak> FindPeaks(int peakThreshold)
        {
            // Create a list to store the peaks.
            List<Peak> peaks = new List<Peak>();

            // Iterate over the spectrogram data.
            for (int i = 0; i < _data.Length; i++)
            {
                for (int j = 0; j < _data[i].Length; j++)
                {
                    // If the magnitude of the current sample is greater than the peak threshold, then it is a peak.
                    if (_data[i][j] > peakThreshold)
                    {
                        // Add the peak to the list of peaks.
                        peaks.Add(new Peak(j, _data[i][j]));
                    }
                }
            }

            return peaks;
        }
    }


}
