using LILO_Packager.v2.Cloud;

namespace LILO_Packager.v2.Contracts
{
    public interface ICloudServiceManager
    {
        ICloudServiceErrorHandler errorHandler { get; set; }

        Task Run(params string[] files);
    }
}