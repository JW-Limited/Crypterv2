using System.Diagnostics;

namespace Crypterv2.DevTool.Core.Plugins
{
    public class PackageManagerProgress
    {
        public Stopwatch stopwatch = new Stopwatch();

        public PackageManagerProgress() 
        {
            stopwatch.Start();
        }

        public int TotalItems { get; set; }
        public int CurrentItem { get; set; }
        public string Message { get; set; }
        public decimal Percentage 
        {
            get 
            {
                try { return (decimal)CurrentItem / TotalItems * 100; }
                catch { return 0; }
            }
        }
        public TimeSpan EstimatedTimeRemaining
        {
            get 
            { 
                return TimeSpan.FromSeconds((double)(Percentage / 100 * (int)stopwatch.Elapsed.TotalSeconds)); 
            }
        }
    }
}
