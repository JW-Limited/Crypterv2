using JWLimited.Contracts.LILO;
using JWLimited.Cryptography.Nodes;
using System.IO.Compression;

namespace JWLimited.Cryptography
{
    public class CryptographyManager
    {
        private static CryptographyManager? _tempInstance = null;

        private readonly NodeManager<byte[]> _nodeManager;
        private readonly Splitter _splitter;
        private readonly IServiceValues _serviceValues;

        internal CryptographyManager(IServiceValues values) 
        {
            _serviceValues = values;
            _nodeManager = new NodeManager<byte[]>();
            _splitter = new Splitter(_nodeManager);
        }

        ~CryptographyManager()
        {
            _tempInstance = null;
        }

        public static CryptographyManager Instance
        {
            get
            {
                if(_tempInstance == null)
                {
                    throw new NotInitializedException(nameof(CryptographyManager));
                }

                return _tempInstance;
            }

        }

        public static CryptographyManager Create(IServiceValues values)
        {
            var newInstance = new CryptographyManager(values);

            _tempInstance = newInstance;

            return newInstance;
        }

        public async Task<(bool, Dictionary<string, ILILOResponse>)> EncryptFileWithService(Action<string> _errorCallback)
        {
            try
            {
                var services = new Services(_serviceValues);
                var result = await services.CompressAndEncryptFileAsync();

                _serviceValues.CurrentWorkingTask?.Invoke("Encrypted file: " + _serviceValues.FileInput);

                if (result.Item1)
                {
                    var splitResult = await _splitter.SplitAndSave(_serviceValues.FileOutput, 4);

                    using (FileStream stream = new FileStream(_serviceValues.FileOutput + "~tmp", FileMode.Create))
                    using (ZipArchive archieve = new ZipArchive(stream, ZipArchiveMode.Create))
                    {
                        foreach (var chunkedFile in splitResult.GeneratedFiles)
                        {
                            archieve.CreateEntryFromFile(chunkedFile, new FileInfo(chunkedFile).Name);
                        }
                    }

                    File.Delete(_serviceValues.FileOutput);

                    File.Move(_serviceValues.FileOutput + "~tmp", _serviceValues.FileOutput);

                    return result;
                }
                else
                {
                    Console.WriteLine("The Operation didnt complett successfully.");
                }
                (bool, Dictionary<string, ILILOResponse>) value = (false, null);
                return value;
            }
            catch (Exception ex)
            {
                _errorCallback?.Invoke($"Error: {ex}");
                Console.WriteLine(ex.Message);

                (bool, Dictionary<string, ILILOResponse>) value = (false, null);
                return value;
            }
        }

    }
}
