using Crypterv2.DevTool.Core.Contracts;

namespace Crypterv2.DevTool.Core.Plugins
{
    public class PackageManagerResponse : ILILOResponse
    {
        public static PackageManagerResponse Error(Exception ex) => new PackageManagerResponse(ex);

        public bool Success { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public uint EndCode { get; set; }
        public uint ErrorCode { get; set; }

        private PackageManagerResponse()
        {
        }

        public PackageManagerResponse(Exception ex)
        {
            Success = false;
            IsError = true;
            Message = ex.Message;
            Status = ex.GetType().Name;
            EndCode = (uint)ex.HResult;
        }

        public static PackageManagerResponse SuccessFull()
        {
            return new PackageManagerResponse
            {
                Success = true,
                IsError = false,
                Message = "Operation successful.",
                Status = "Success",
                EndCode = DevToolCodes.SuccessfullCreatedPackage
            };
        }

        public static PackageManagerResponse Failure(string message)
        {
            return new PackageManagerResponse
            {
                Success = false,
                IsError = true,
                Message = message,
                Status = "Failure",
                EndCode = DevToolCodes.UnknownPackageCreationError
            };
        }

        public static PackageManagerResponse FromException(Exception ex)
        {
            return new PackageManagerResponse(ex);
        }

        public override string ToString()
        {
            return $"[{Status}] {Message}";
        }
    }
}

