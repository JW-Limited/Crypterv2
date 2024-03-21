using JWLimited.Licensing.Schemes.Contracts;

namespace JWLimited.Licensing.Schemes.Templates
{
    public class License : IProductLicense
    {
        private string licenseName;
        private string licenseKey;
        private DateTime licensePayDay;
        private bool subscription;
        private DateTime dieDay;
        private List<IProductFeature> extendingProductFeatures;

        public License() 
        {
        }

        public License(string licenseName, string licenseKey, DateTime licensePayDay, bool subscription, DateTime dieDay)
        {
            this.licenseName = licenseName;
            this.licenseKey = licenseKey;
            this.licensePayDay = licensePayDay;
            this.subscription = subscription;
            this.dieDay = dieDay;
            this.extendingProductFeatures = new List<IProductFeature>();
        }

        public static License Trail(string licenseName)
        {
            var license = new License()
            {
                LicenseName = licenseName,
                LicenseKey = "trail-key",
                LicensePayDay = DateTime.Today.AddDays(30),
                DieDay = DateTime.Today.AddDays(31),
                Subscription = false,
                ExtendingProductFeatures = new List<IProductFeature>() { }
            };

            return license;
        }

        public static License FeeFree(string licenseName)
        {
            var license = new License()
            {
                LicenseName = licenseName,
                LicenseKey = "none",
                Subscription = false,
            };

            return license;
        }

        public static License SubscriptionBased(string licenseName, string licenseKey, string featureName, DateTime featurePayDay, DateTime subscriptionEndDay,List<IProductFeature> includedFeatureSet)
        {
            var license = new License()
            {
                LicenseName = licenseName,
                LicenseKey = licenseKey,
                LicensePayDay = DateTime.Today,
                DieDay = DateTime.Today.AddDays(31),
                Subscription = true,
                ExtendingProductFeatures = includedFeatureSet
            };

            return license;
        }


        public string LicenseName
        {
            get => licenseName;
            set => licenseName = value;
        }

        public string LicenseKey
        {
            get => licenseKey;
            set => licenseKey = value;
        }

        public DateTime LicensePayDay
        {
            get => licensePayDay;
            set => licensePayDay = value;
        }

        public bool Subscription
        {
            get => subscription;
            set => subscription = value;
        }

        public DateTime DieDay
        {
            get => dieDay;
            set => dieDay = value;
        }

        public List<IProductFeature> ExtendingProductFeatures
        {
            get => extendingProductFeatures;
            set => extendingProductFeatures = value;
        }
    }
}
