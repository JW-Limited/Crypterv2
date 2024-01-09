using JWLimited.Licensing.Schemes.Contracts;
namespace EncryptionLibary;
public class ProductFeature : IProductFeature
{
    public string FeatureName { get; set; } = "EncryptenExtender";

    public string FeatureKey { get; set; } = "6ff6f6f";

    public DateTime FeaturePayDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Subscription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string FeatureID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}