using JWLimited.Cryptography;
using JWLimited.TestHost.Core.APILib;
using JWLimited.TestHost.Core.Cryptography;
using JWLimited.TestHost.Core.Licx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWLimited.TestHost.Core
{
    public enum TestableClasses
    {
        Cryptography_Encryptv2 = 1,
        Cryptography_Decryptv2 = 2,
        WebEngine_Server = 3,
        DeezerApi = 4,
        LicenseGenerator = 5
    }

    public class TestManager
    {
        public static TestManager Instance { get => instance.Value; }
        private static Lazy<TestManager> instance = new Lazy<TestManager>(() => new TestManager());

        public TestManager() 
        {
        }

        public async Task ExecuteTest(int test)
        {
            if(test == 1)
            {
                try
                {
                    var encMNG = new EncryptenManager();
                    await encMNG.LFS_LFSO_NMS();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Failed to encrypt: {ex.Message}");
                    Console.ReadKey();
                    Program.Main(null);
                }
            }
            else if(test == 3)
            {
                var WebMng = WebServer.Manager.Instance;
                await WebMng.RequestNewSession();
            }
            else if( test == 4)
            {
                var mng = new DeezerHandler();
                mng.AcceptRequests();
            }
            else if (test == 5)
            {
                LicenseManager.Instance.PrintLicense();
            }
        }

        public Dictionary<int,string> GetAllTests()
        {
            int i = 1;
            return Enum.GetValues(typeof(TestableClasses)).Cast<TestableClasses>()
            .Select(feature => new KeyValuePair<int,string>(i++, feature.ToString()))
            .ToDictionary();
        }
    }
}
