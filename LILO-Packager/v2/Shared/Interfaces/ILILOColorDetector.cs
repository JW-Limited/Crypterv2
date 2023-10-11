namespace LILO_Packager.v2.Shared.Interfaces
{
    public interface ILILOColorDetector
    {
        Task<Color> DetectMainColor();
        Task<Color> GetOppositeColor(Color color);
    }
}