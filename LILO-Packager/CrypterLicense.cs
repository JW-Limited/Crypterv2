using CommandLine;
using JWLimited.Licensing.Schemes;
using JWLimited.Licensing.Schemes.Contracts;
using JWLimited.Licensing.Schemes.Structs;
using LILO_Packager.v2.Core.LILO;
using LILO_Packager.v2.Core.Updates;

namespace LILO_Packager
{
    public class CrypterLicense : IJWLimitedLicense
    {
        public IProductLicense License { get; set; } = new ProductLicense();
        public JWLimited.Licensing.Schemes.Structs.User OwnedUser
        {
            get
            {
                var appUser = UserManager.Instance().LoadUserFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"));
                var jwUser = new User()
                {
                    Email = appUser.Email,
                    Password = appUser.Password,
                    RegistrationDate = appUser.RegistrationDate,
                    Role = appUser.Role
                };

                return jwUser;
            }
            set
            {
            }
        }
        public IProduct Product { get; set; } = new ProductInformation();
    }

    public class ProductLicense : IProductLicense
    {
        public string LicenseName { get; set; } = "Professional Developer Edition";
        public string LicenseKey { get; set; } = "6398-4338-4463-76-435";
        public DateTime LicensePayDay { get; set; }
        public bool Subscription { get; set; }
        public DateTime DieDay { get; set; }
        public List<IProductFeature> ExtendingProductFeatures { get; set; }
    }

    public class ProductInformation : IProduct
    {
        public string FriendlyName => "Crypterv2";

        public string FullName => Program.LibraryName;

        public ProductVersion Version 
        { 
            get
            {
                var version = new ProductVersion();
                var PrgVersion = VersionComparer.ParseSemanticVersion(Program.Version);

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
                var PrgVersion = VersionComparer.ParseSemanticVersion(Program.Version);

                version.Major = PrgVersion.Major + 1;
                version.Minor = PrgVersion.Minor;
                version.Patch = PrgVersion.Patch;

                return version;
            }
        }
    }


    public class CrypterLicenseTrail : IJWLimitedLicense
    {
        public IProductLicense License { get; set; } = JWLimited.Licensing.Schemes.Templates.License.Trail("Professional Developer Edition (Trail)");
        public JWLimited.Licensing.Schemes.Structs.User OwnedUser 
        { 
            get 
            {
                var appUser = UserManager.Instance().LoadUserFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"));
                var jwUser = new User()
                {
                    Email = appUser.Email,
                    Password = appUser.Password,
                    RegistrationDate = appUser.RegistrationDate,
                    Role = appUser.Role
                };
                
                return jwUser;
            }
            set
            { 
            } 
        }
        public IProduct Product { get; set; } = new ProductInformation();
    }
}
    