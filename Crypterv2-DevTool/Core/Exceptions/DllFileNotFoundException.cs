using System.Reflection;

namespace Crypterv2.DevTool.Core.Exceptions
{
    public class DllFileNotFoundException : Exception
    {
        public DllFileNotFoundException()
        {
        }

        public static AssemblyName GetAssemblyInfo(string filePath)
        {
            Assembly assembly = Assembly.LoadFrom(filePath);
            AssemblyName assemblyName = assembly.GetName();

            return assemblyName;
        }

        public DllFileNotFoundException(string fileName, string errorMessage) : base(errorMessage)
        {
            FileName = fileName;
        }

        public string FileName { get; set; }
        public string ErrorMessage { get; set; }
        public string AssemblyName { get; set; }
        public Version AssemblyVersion { get; set; }
        public string AssemblyPath { get; set; }


        public override string ToString()
        {
            return $"DllFileNotFoundException: FileName={FileName}, ErrorMessage={ErrorMessage}, AssemblyName={AssemblyName}, AssemblyVersion={AssemblyVersion}, AssemblyPath={AssemblyPath}";
        }

        public static DllFileNotFoundException FromFile(string fileName)
        {
            AssemblyName assemblyName = null;
            Version assemblyVersion = null;
            string assemblyPath = null;

            try
            {
                assemblyName = GetAssemblyInfo(fileName);
                assemblyVersion = assemblyName.Version;
                assemblyPath = Assembly.LoadFrom(fileName).Location;
            }
            catch (Exception)
            {

            }

            return new DllFileNotFoundException(fileName, "The DLL file could not be found.")
            {
                AssemblyName = assemblyName?.Name,
                AssemblyVersion = assemblyVersion,
                AssemblyPath = assemblyPath
            };
        }
    }


}
