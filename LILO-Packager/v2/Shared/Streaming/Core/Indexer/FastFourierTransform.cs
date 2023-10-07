namespace LILO_Packager.v2.Shared.Streaming.Core.Indexer
{
    public class FastFourierTransform
    {
        public static void Fft(Complex[] complexNumbers)
        {
            // If the length of the complex number array is not a power of two, then return.
            if (!IsPowerOfTwo(complexNumbers.Length))
            {
                return;
            }

            // Recursively compute the FFT of the complex number array.
            RecursivelyComputeFft(complexNumbers, 0, complexNumbers.Length);
        }

        private static void RecursivelyComputeFft(Complex[] complexNumbers, int startIndex, int length)
        {
            // If the length of the complex number array is 1, then return.
            if (length == 1)
            {
                return;
            }

            // Divide the complex number array into two halves.
            Complex[] evenComplexNumbers = new Complex[length / 2];
            Complex[] oddComplexNumbers = new Complex[length / 2];
            for (int i = 0; i < length / 2; i++)
            {
                evenComplexNumbers[i] = complexNumbers[startIndex + 2 * i];
                oddComplexNumbers[i] = complexNumbers[startIndex + 2 * i + 1];
            }

            RecursivelyComputeFft(evenComplexNumbers, 0, length / 2);
            RecursivelyComputeFft(oddComplexNumbers, 0, length / 2);

            for (int i = 0; i < length / 2; i++)
            {
                Complex complexNumber = Complex.Multiply(Complex.Add(evenComplexNumbers[i], oddComplexNumbers[i]), new Complex(0, -2 * Math.PI * i / length));
                complexNumbers[startIndex + i] = complexNumber;

                complexNumber = Complex.Multiply(Complex.Subtract(evenComplexNumbers[i], oddComplexNumbers[i]), new Complex(0, -2 * Math.PI * i / length));
                complexNumbers[startIndex + length / 2 + i] = complexNumber;
            }
        }

        private static bool IsPowerOfTwo(int number)
        {
            return number != 0 && (number & number - 1) == 0;
        }
    }


}
