namespace LILO_Packager.v2.streaming.MusikPlayer.Core.Indexer
{
    public class Peak
    {
        public double Frequency { get; set; }
        public double Magnitude { get; set; }

        public Peak(double frequency, double magnitude)
        {
            Frequency = frequency;
            Magnitude = magnitude;
        }
    }


}
