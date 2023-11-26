using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LILO_Packager.v2.Contracts;
using LILO_Packager.v2.Shared;

namespace LILO_Packager.v2.Cloud
{
    public class CloudServiceManager : ICloudServiceManager
    {
        private const int MINPARAMS = 1;
        private readonly ICloudService _uploader;
        private readonly Action<string> _statusCallback;
        private readonly Action<long, long> _progressCallback;
        public ICloudServiceErrorHandler errorHandler { get; set; }

        public CloudServiceManager(ICloudService uploader, Action<string> statusCallback, Action<long, long> progressCallback, ICloudServiceErrorHandler errorHandler = null)
        {
            _uploader = uploader ?? throw new ArgumentNullException(nameof(uploader));
            _statusCallback = statusCallback ?? throw new ArgumentNullException(nameof(statusCallback));
            _progressCallback = progressCallback ?? throw new ArgumentNullException(nameof(progressCallback));
            this.errorHandler = errorHandler ?? DefaultErrorHandler.Instance;
        }

        public async Task Run(params string[] files)
        {
            if (files.Length < MINPARAMS)
            {
                _statusCallback("All youre Files are Synced.");
                return;
            }

            await CheckFilesAndUpload(files);
        }

        private async Task CheckFilesAndUpload(string[] files)
        {
            foreach (var file in files)
            {
                if (!File.Exists(file))
                {
                    _statusCallback($"File '{file}' does not exist.");
                    continue;
                }
            }

            //var uniqueFiles = new HashSet<string>(files);
            //if (uniqueFiles.Count < files.Length)
            //{
            //    _statusCallback("Duplicate files detected. Please provide only unique files.");
            //    return;
            //}


            foreach (var file in files)
            {
                var fileSize = new FileInfo(file).Length;
                if (fileSize > 500 * 1024 * 1024)
                {
                    _statusCallback($"File '{file}' exceeds the maximum file size limit of 500 MB.");
                    continue;
                }
            }

            await _uploader.UploadFiles(files.ToArray(), _statusCallback, _progressCallback);
        }
    }

    public interface ICloudServiceErrorHandler
    {
        void HandleError(Exception ex);
    }


    public class DefaultErrorHandler : ICloudServiceErrorHandler
    {
        private static Lazy<DefaultErrorHandler> ErrorHandler = new Lazy<DefaultErrorHandler>();

        public static DefaultErrorHandler Instance => ErrorHandler.Value;

        public List<string> Errors { get; private set; } = new List<string>();

        public DefaultErrorHandler()
        {
        }

        public void HandleError(Exception ex)
        {
            var errorMessage = $"An error occurred during the upload process:\n{ex.GetType().Name}: {ex.Message}";

            if (ex is HttpProtocolException)
            {
                var httpException = (HttpProtocolException)ex;
                errorMessage += $"\nStatus Code: {httpException.ErrorCode}";
            }
            else if (ex is TimeoutException)
            {
                errorMessage += "\nThe upload operation timed out.";
            }
            else if (ex is IOException)
            {
                errorMessage += "\nAn I/O error occurred during the upload.";
            }

            Errors.Add(errorMessage);

            ConsoleManager.Instance().WriteLineWithColor($"{errorMessage}", ConsoleColor.Red);
            ConsoleManager.Instance().WriteLineWithColor("Please check your internet connection and try again later.", ConsoleColor.Yellow);
        }
    }

}
