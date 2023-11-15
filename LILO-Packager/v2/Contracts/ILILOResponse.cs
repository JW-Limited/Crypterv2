namespace LILO_Packager.v2.Contracts;
    public interface ILILOResponse
    {
        uint EndCode { get; set; }
        uint ErrorCode { get; set; }
        string Message { get; set; }
        bool Success { get; set; }
    }
