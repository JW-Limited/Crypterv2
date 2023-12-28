using JWLimited.Licensing.Schemes.Contracts;

namespace TextPreviewLibrary
{
    public class ProductFeature : IProductFeature
    {
        public string FeatureName { get; set; } = "ContentHandlingExtender";

        public string FeatureKey { get; set; } = "4777323S";

        public DateTime FeaturePayDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Subscription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FeatureID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}