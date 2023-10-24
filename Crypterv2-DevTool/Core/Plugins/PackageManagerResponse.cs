namespace Crypterv2.DevTool.Core.Plugins
{
    public class PackageManagerResponse
    {
        public static PackageManagerResponse Error(Exception ex) => new PackageManagerResponse(ex);

        public bool IsSuccess { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public uint EndingCode { get; set; }

        private PackageManagerResponse()
        {
        }

        public PackageManagerResponse(Exception ex)
        {
            IsSuccess = false;
            IsError = true;
            Message = ex.Message;
            Status = ex.GetType().Name;
            EndingCode = (uint)ex.HResult;
        }

        public static PackageManagerResponse Success()
        {
            return new PackageManagerResponse
            {
                IsSuccess = true,
                IsError = false,
                Message = "Operation successful.",
                Status = "Success",
                EndingCode = 0
            };
        }

        public static PackageManagerResponse Failure(string message)
        {
            return new PackageManagerResponse
            {
                IsSuccess = false,
                IsError = true,
                Message = message,
                Status = "Failure",
                EndingCode = 1
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

