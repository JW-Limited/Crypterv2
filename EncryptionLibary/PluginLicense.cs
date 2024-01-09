using JWLimited.Licensing.Schemes.Contracts;
namespace EncryptionLibary;
public class PluginLicense : IProductLicense
{
    public string LicenseName { get; set; } = "JW Limited - Encryption Library (Cryptex)";

    public string LicenseKey { get; set; } = "639-433-4463-76-435";

    public DateTime LicensePayDay { get; set; } = DateTime.MaxValue;

    public bool Subscription { get; set; } = false;

    public DateTime DieDay { get; set; } = DateTime.MaxValue;

    public List<IProductFeature> ExtendingProductFeatures { get; set; } = new List<IProductFeature>()
    {
        new ProductFeature()
    };
}
