using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core
{
    public class FeatureManager
    {
        private static readonly string ConfigFilePath = "featureManager.dll";
        private static FeatureFlagConfig _config;
        private static readonly Dictionary<FeatureFlags, bool> _featureFlagsDictionary = new Dictionary<FeatureFlags, bool>();

        public static event EventHandler<FeatureFlagUpdateEventArgs> FeatureFlagsChanged;

        public static async Task LoadConfigurationAsync()
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    string json = await File.ReadAllTextAsync(ConfigFilePath);
                    _config = JsonConvert.DeserializeObject<FeatureFlagConfig>(json);
                }
                else
                {
                    _config = new FeatureFlagConfig();
                    await SaveConfigurationAsync();
                }

                foreach (FeatureFlags flag in Enum.GetValues(typeof(FeatureFlags)))
                {
                    _featureFlagsDictionary[flag] = GetFlagFromService(flag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading configuration: {ex.Message}");
                _config = new FeatureFlagConfig();
            }
        }

        private static bool GetFlagFromService(FeatureFlags feature)
        {
            return _config.GetType().GetProperty(feature.ToString())?.GetValue(_config) as bool? ?? false;
        }

        public static bool IsFeatureEnabled(FeatureFlags feature)
        {
            return _featureFlagsDictionary.ContainsKey(feature) && _featureFlagsDictionary[feature];
        }

        public static async Task ToggleFeatureAsync(FeatureFlags feature)
        {
            if (!_featureFlagsDictionary.ContainsKey(feature))
                return;

            bool newValue = !_featureFlagsDictionary[feature];
            _featureFlagsDictionary[feature] = newValue;

            _config.GetType().GetProperty(feature.ToString())?.SetValue(_config, newValue);
            await SaveConfigurationAsync();

            FeatureFlagsChanged?.Invoke(null, new FeatureFlagUpdateEventArgs(feature, newValue));
        }

        private static async Task SaveConfigurationAsync()
        {
            try
            {
                string json = JsonConvert.SerializeObject(_config, Formatting.Indented);
                await File.WriteAllTextAsync(ConfigFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving configuration: {ex.Message}");
            }
        }
    }

    public static class FeatureFlagEvents
    {
        public static event EventHandler<FeatureFlagUpdateEventArgs> FeatureFlagUpdateRequested;

        public static void OnFeatureFlagUpdateRequested(FeatureFlags feature, bool isEnabled)
        {
            FeatureFlagUpdateRequested?.Invoke(null, new FeatureFlagUpdateEventArgs(feature, isEnabled));
        }
    }

    public class FeatureFlagUpdateEventArgs : EventArgs
    {
        public FeatureFlags Flag { get; }
        public bool NewValue { get; }

        public FeatureFlagUpdateEventArgs(FeatureFlags flag, bool newValue)
        {
            Flag = flag;
            NewValue = newValue;
        }
    }
}
