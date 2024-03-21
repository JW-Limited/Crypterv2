using JWLimited.Licensing.Schemes;
using JWLimited.Licensing.Schemes.Contracts;
using JWLimited.Licensing.Schemes.Structs;
using JWLimited.Licensing.Schemes.Templates;
using LILO_Packager.v2.Core.Updates;

namespace JWLimited.TestHost.Core.Licx
{
    public class LicenseManager
    {
        public static LicenseManager Instance => _instance.Value;
        private static Lazy<LicenseManager> _instance = new Lazy<LicenseManager>(() => new LicenseManager());
        private readonly AuthAgent _agent;
        private readonly JWLimited.Licensing.Core.LicenseManager _licenseManager;

        internal LicenseManager() 
        {
            _agent = AuthAgent.CreateAgent(new Application()
            {
                Executable = Environment.ProcessPath,
                Name = "JWLimited.TestHost",
                ProjectLink = "",
                RealName = "JWLimited.TestHost.Windows.Collections"
            });

            _licenseManager = JWLimited.Licensing.Core.LicenseManager.Initialize(_agent);
        }

        public void PrintLicense()
        {
            Console.Clear();
            Console.WriteLine("[LICX - MODULE] License Generator (by JW Limited):\n\n");
            Console.Write("Product: ");
            var product = Console.ReadLine();
            Console.Write("Path: ");
            var path = Console.ReadLine();
            var result = GenerateLicense(path, product);

            if (!result)
            {
                Console.WriteLine("An error happend while the generator generated the license.");
                return;
            }

            Console.WriteLine("Succes!!");
        }

        private bool GenerateLicense(string path, string name)
        {
            try
            {
                var license = new TemplateLicense(name);

                return _licenseManager.WriteLicense<TemplateLicense>(license, path + "\\license.licx");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.Source);
                return false;
            }
        }
    }

    public class TemplateLicense : IJWLimitedLicense
    {
        public TemplateLicense()
        {

        }

        public TemplateLicense(string name)
        {
            License = JWLimited.Licensing.Schemes.Templates.License.FeeFree(name);
            OwnedUser = new User()
            {
                Email = "test@jwlmt.com",
                RegistrationDate = DateTime.Now,
                Password = "",
                Role = "user"
            };

            Product = new ProductInformation();
        }

        public IProductLicense License { get; set; }
        public User OwnedUser { get; set; }
        public IProduct Product { get; set; }
    }

    public class ProductInformation : IProduct
    {
        public string FriendlyName => "Crypterv2";

        public string FullName => LILO_Packager.Program.LibraryName;

        public ProductVersion Version
        {
            get
            {
                var version = new ProductVersion();
                var PrgVersion = VersionComparer.ParseSemanticVersion(LILO_Packager.Program.Version);

                version.Major = PrgVersion.Major;
                version.Minor = PrgVersion.Minor;
                version.Patch = PrgVersion.Patch;

                return version;
            }
        }

        public ProductVersion MaxedVersion
        {
            get
            {
                var version = new ProductVersion();
                var PrgVersion = VersionComparer.ParseSemanticVersion(LILO_Packager.Program.Version);

                version.Major = PrgVersion.Major + 1;
                version.Minor = PrgVersion.Minor;
                version.Patch = PrgVersion.Patch;

                return version;
            }
        }
    }
}
