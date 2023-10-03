namespace LILO_Packager.v2.streaming.MusikPlayer.Core.Indexer
{
    public class Complex : IComplex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public Complex(double real)
        {
            Real = real;
            Imaginary = 0;
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        public static Complex Add(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex Subtract(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static Complex Multiply(Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
        }

        public static Complex Divide(Complex a, Complex b)
        {
            double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
            return new Complex((a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator, (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator);
        }
    }


}
