using Microsoft.Extensions.DependencyModel;
using System.Diagnostics;

namespace Crypterv2.DevTool.Core.Plugins
{
    public class DependencyWalker : IDisposable
    {
        private readonly string dllPath;
        private bool disposedValue;

        public DependencyWalker(string dllPath)
        {
            this.dllPath = dllPath;
        }

        public IEnumerable<Dependency> GetDependencies()
        {
            using (var dependencyWalker = Process.Start("depends.exe", this.dllPath))
            {
                dependencyWalker.WaitForExit();

                using (var reader = dependencyWalker.StandardOutput)
                {
                    while (reader.Peek() != -1)
                    {
                        var line = reader.ReadLine();

                        if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                        {
                            continue;
                        }

                        var parts = line.Split(',');
                        var dependencyName = parts[0].Trim();
                        var dependencyVersion = parts[1].Trim();

                        var dependency = new Dependency(dependencyName, dependencyVersion);
                        yield return dependency;
                    }
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}
