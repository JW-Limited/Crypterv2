namespace Crypterv2.DevTool.Core.Contracts
{
    public interface ILILOProgress
    {
        int CurrentItem { get; set; }
        TimeSpan EstimatedTimeRemaining { get; }
        string Message { get; set; }
        decimal Percentage { get; }
        int TotalItems { get; set; }
    }
}