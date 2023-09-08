using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LILO_Packager.v2.Core.ColorManager
{
    public class DarkWhiteModeManager
    {
        private Dictionary<Control, ControlSettings> controlSettings = new Dictionary<Control, ControlSettings>();
        private Dictionary<ControlType, Dictionary<ModeType, ModeSettings>> modeSettings = new Dictionary<ControlType, Dictionary<ModeType, ModeSettings>>();
        private ModeType currentMode = ModeType.Dark; // Initial mode

        public event EventHandler ModeChanged;

        private static DarkWhiteModeManager instance;

        public static DarkWhiteModeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DarkWhiteModeManager();
                }
                return instance;
            }
        }

        public ModeType CurrentMode
        {
            get { return currentMode; }
            set
            {
                if (currentMode != value)
                {
                    currentMode = value;
                    OnModeChanged();
                }
            }
        }

        private DarkWhiteModeManager()
        {
            RegisterControlsInApplication();
        }

        public void RegisterControl(Control control, ControlType controlType, ModeType modeType, Color backColor, Color foreColor)
        {
            if (!controlSettings.ContainsKey(control))
            {
                controlSettings[control] = new ControlSettings();
            }

            var settings = controlSettings[control];
            settings.ControlType = controlType;
            settings.ModeSettings[modeType] = new ModeSettings
            {
                BackColor = backColor,
                ForeColor = foreColor,
            };
        }

        public void RegisterModeSettings(ControlType controlType, ModeType modeType, Color backColor, Color foreColor)
        {
            if (!modeSettings.ContainsKey(controlType))
            {
                modeSettings[controlType] = new Dictionary<ModeType, ModeSettings>();
            }

            modeSettings[controlType][modeType] = new ModeSettings
            {
                BackColor = backColor,
                ForeColor = foreColor,
            };
        }

        public void ApplyMode(ModeType modeType)
        {
            foreach (var kvp in controlSettings)
            {
                var control = kvp.Key;
                var controlSettings = kvp.Value;
                ControlType controlType = controlSettings.ControlType;

                if (controlSettings.ModeSettings.TryGetValue(modeType, out var specificSettings))
                {
                    ApplySettings(control, specificSettings);
                }
                else if (modeSettings.ContainsKey(controlType) && modeSettings[controlType].TryGetValue(modeType, out var inheritedSettings))
                {
                    ApplySettings(control, inheritedSettings);
                }
            }

            CurrentMode = modeType;
        }

        public void ToggleMode()
        {
            CurrentMode = CurrentMode == ModeType.Dark ? ModeType.White : ModeType.Dark;
        }

        private void ApplySettings(Control control, ModeSettings settings)
        {
            control.BackColor = settings.BackColor;
            control.ForeColor = settings.ForeColor;
        }

        protected virtual void OnModeChanged()
        {
            ModeChanged?.Invoke(this, EventArgs.Empty);
        }

        private void RegisterControlsInApplication()
        {
            // Automatically detect and register controls in the application
            // You can use reflection to find and register controls based on custom attributes or other criteria.
            // For simplicity, here's a basic example that registers all known controls within the application.
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var controlTypes = assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(Control)));
                foreach (var controlType in controlTypes)
                {
                    RegisterControlDefaults(controlType);
                }
            }
        }

        private void RegisterControlDefaults(Type controlType)
        {
            // Define default mode settings for each control type
            if (controlType == typeof(TextBox))
            {
                RegisterModeSettings(ControlType.TextBox, ModeType.Dark, Color.Black, Color.White);
                RegisterModeSettings(ControlType.TextBox, ModeType.White, Color.White, Color.Black);
            }
            else if (controlType == typeof(Button))
            {
                RegisterModeSettings(ControlType.Button, ModeType.Dark, Color.DarkGray, Color.White);
                RegisterModeSettings(ControlType.Button, ModeType.White, Color.LightGray, Color.Black);
            }
            // Add more control types and default settings as needed
        }
    }

    public enum ControlType
    {
        TextBox,
        Button,
        Label,
        // Add more control types as needed
    }

    public enum ModeType
    {
        Dark,
        White,
        // Add more mode variants as needed
    }

    public class ControlSettings
    {
        public ControlType ControlType { get; set; }
        public Dictionary<ModeType, ModeSettings> ModeSettings { get; } = new Dictionary<ModeType, ModeSettings>();
    }

    public class ModeSettings
    {
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
    }

}
