using JWLimited.Licensing.Schemes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeezerPlugin
{
    public class PluginLicense : IProductLicense
    {
        public string LicenseName { get; set; } = "JW Limited - DeezerPlugin (DEZCry)";

        public string LicenseKey { get; set; } = "639-433-4463-76-435"; // The Key for free use.

        public DateTime LicensePayDay { get; set; } = DateTime.MaxValue;

        public bool Subscription { get; set; } = false;

        public DateTime DieDay { get; set; } = DateTime.MaxValue;

        public List<IProductFeature> ExtendingProductFeatures { get; set; } = new List<IProductFeature>()
        {
            new ProductFeature()
        };

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
}
