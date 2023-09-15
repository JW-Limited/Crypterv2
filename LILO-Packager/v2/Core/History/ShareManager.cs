
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;

namespace LILO_Packager.v2.Core.History
{
    public class ShareManager
    {
        private readonly DataTransferManager dataTransferManager;
        private string sharedFilePath;
        private string sharedText;

        public ShareManager()
        {
            var dataTransferManager = DataTransferManager.GetForCurrentView();
            dataTransferManager.DataRequested += DataTransferManager_DataRequested;
        }

        public async Task OpenShareDialogAsync(string filePath, string text = null)
        {
            if (string.IsNullOrEmpty(filePath) && string.IsNullOrEmpty(text))
                throw new ArgumentException("Either filePath or text must be provided.");

            this.sharedFilePath = filePath;
            this.sharedText = text;

            DataTransferManager.ShowShareUI();
        }

        private async void DataTransferManager_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            var request = args.Request;

            if (request != null)
            {
                request.Data.Properties.Title = "Share File";
                request.Data.Properties.Description = "Sharing a file from my app.";

                if (!string.IsNullOrEmpty(sharedFilePath))
                {
                    try
                    {
                        var storageFile = await StorageFile.GetFileFromPathAsync(sharedFilePath);
                        var storageItems = new IStorageItem[] { storageFile };
                        request.Data.SetStorageItems(storageItems);
                    }
                    catch (Exception ex)
                    {
                    }
                }

                if (!string.IsNullOrEmpty(sharedText))
                {
                    request.Data.SetText(sharedText);
                }
            }
        }
    }
}

