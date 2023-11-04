using Microsoft.FSharp.Core;

namespace Crypterv2.DevTool.Core
{
    public struct DevToolCodes
    {
        public DevToolCodes()
        {
        }

        public static uint NoPreSavedConfigsFound = 0x100392;
        public static uint AccessViolation = 0x100452;
        public static uint SuccessfullSerialized = 0x200609;
        public static uint UnknownAllocationError = 0x300807;
        public static uint SuccessfullAllocated = 0x300001;
        public static uint UnknownError = 0x900000;
        public static uint SuccessfullCreatedPackage = 0x500406;
        public static uint UnknownPackageCreationError = 0x500367;

        public static string ToString(uint code)
        {
            return $"0x{code.ToString("X")}";
        }
    }
}
