namespace LILO_Packager.v2.Shared.Streaming.Core.Indexer
{
    public class FourierTransform
    {
        public double[][] ComputeSpectrogram(byte[] audioData, int windowSize, int hopSize)
        {
            // Create a Hanning window.
            double[] hanningWindow = new double[windowSize];
            for (int i = 0; i < windowSize; i++)
            {
                hanningWindow[i] = 0.5 - 0.5 * Math.Cos(2 * Math.PI * i / (windowSize - 1));
            }

            List<double[]> spectrogramData = new List<double[]>();

            for (int i = 0; i < audioData.Length; i += hopSize)
            {
                byte[] windowData = new byte[windowSize];
                Buffer.BlockCopy(audioData, i, windowData, 0, windowSize);

                for (int j = 0; j < windowSize; j++)
                {
                    byte[] byteArray = BitConverter.GetBytes(hanningWindow[j]);
                    windowData[j] = (byte)(windowData[1] * byteArray[1]);
                }

                double[] fourierTransform = ComputeFourierTransform(windowData);

                spectrogramData.Add(fourierTransform);
            }

            double[][] spectrogramArray = new double[spectrogramData.Count][];
            for (int i = 0; i < spectrogramData.Count; i++)
            {
                spectrogramArray[i] = spectrogramData[i];
            }

            return spectrogramArray;
        }

        private double[] ComputeFourierTransform(byte[] windowData)
        {
            // Create a complex number array to store the Fourier transform coefficients.
            Complex[] fourierTransformCoefficients = new Complex[windowData.Length];

            // Iterate over the window data and compute the Fourier transform coefficients.
            for (int i = 0; i < windowData.Length; i++)
            {
                fourierTransformCoefficients[i] = new Complex(windowData[i]);
            }

            // Compute the Fast Fourier Transform (FFT) of the complex number array.
            FastFourierTransform.Fft(fourierTransformCoefficients);

            // Compute the magnitude spectrum of the Fourier transform coefficients.
            double[] magnitudeSpectrum = new double[windowData.Length];
            for (int i = 0; i < windowData.Length; i++)
            {
                magnitudeSpectrum[i] = Math.Sqrt(fourierTransformCoefficients[i].Real * fourierTransformCoefficients[i].Real + fourierTransformCoefficients[i].Imaginary * fourierTransformCoefficients[i].Imaginary);
            }

            return magnitudeSpectrum;
        }
    }


}
