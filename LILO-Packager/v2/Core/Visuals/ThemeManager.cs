﻿using LILO_Packager.v2.Shared;
using Newtonsoft.Json;
using System.Reflection;

namespace LILO_Packager.v2.Core.Visuals
{
    public class ThemeManager
    {
        public class ThemeFileConstructor(Dictionary<string,Theme> themes)
        {
            public FileFormatClearifier FileFormat = new()
            {
                ExtensionPrefix = ".lcs",
                FriendlyName = "LILO Custtom Style",
                SchemeUri = "https://beta.lilo.com/schemes/ui/custom/1",
                Description = "An Collection of Theme for LILO Framework powered Applications.",
                FormatVersion = "1.0",
            };
            public Dictionary<string, Theme> ThemeCollection = themes;
        }
        private Dictionary<string, Theme> themes = new Dictionary<string, Theme>();
        private Theme currentTheme;

        public event EventHandler ThemeChanged;

        public Dictionary<string, Theme> Themes
        {
            get
            {
                if (themes is not null) 
                {
                    return themes;
                }

                themes = new Dictionary<string, Theme>();
                return themes;
            }
        }

        public Theme CurrentTheme
        {
            get { return currentTheme; }
            set
            {
                if (currentTheme != value)
                {
                    currentTheme = value;
                    OnThemeChanged();
                }
            }
        }

        public static ThemeManager Initialize()
        {
            var themeManager = new ThemeManager();

            var assembly = Assembly.GetEntryAssembly();
            var controlTypes = assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(HostForm)));

            foreach (var controlType in controlTypes) 
            {
                try
                {
                   var handle = controlType.InvokeMember("Instance",
                                                       BindingFlags.GetField, null, null, null) as HostForm;
                    themeManager.RegisterControl(handle.HostControlHandle, ModeType.Light, Color.White, Color.Black);
                }
                catch (Exception ex)
                {
                    ConsoleManager.Instance().WriteLineWithColor(ex.Message, ConsoleColor.DarkRed);
                   continue;
                }
            }

            var darkTheme = new Theme
            {
                Name = "Dark",
            };
            darkTheme.ModeSettings[ModeType.Dark] = new ModeSettings
            {
                BackColor = Color.FromArgb(32,32,32),
                ForeColor = Color.White,
            };
            var whiteTheme = new Theme
            {
                Name = "White",
            };

            whiteTheme.ModeSettings[ModeType.Light] = new ModeSettings
            {
                BackColor = Color.White,
                ForeColor = Color.Black,
            };

            themeManager.AddTheme("White", whiteTheme);
            themeManager.AddTheme("Dark", darkTheme);

            return themeManager;
        }

        private Dictionary<Control, ControlSettings> controlSettings = new Dictionary<Control, ControlSettings>();

        public void RegisterControl(Control control, ModeType mode, Color backColor, Color foreColor)
        {
            if (!controlSettings.ContainsKey(control))
            {
                controlSettings[control] = new ControlSettings();
            }

            var settings = controlSettings[control];
            settings.ModeSettings[mode] = new ModeSettings
            {
                BackColor = backColor,
                ForeColor = foreColor
            };
        }

        public void AddTheme(string name, Theme theme)
        {
            themes[name] = theme;
        }

        public void ApplyTheme(string themeName)
        {
            if (themes.TryGetValue(themeName, out var theme))
            {
                CurrentTheme = theme;
                ApplyThemeToControls(System.Windows.Forms.Application.OpenForms[0]);
            }
        }

        // BASIC Mode Switcher

        public void ToggleDarkMode()
        {
            if (CurrentTheme.Name == "Dark")
            {
                Console.WriteLine("Switching to White");

                ApplyTheme("White");
            }
            else
            {
                Console.WriteLine("Switching to Dark");

                ApplyTheme("Dark");
            }
        }

        private void ApplyThemeToControls(Control control)
        {
            if (control == null)
                return;

            if (control is ContainerControl container)
            {
                foreach (Control childControl in container.Controls)
                {
                    ApplyThemeToControls(childControl);
                }
            }

            if (controlSettings.TryGetValue(control, out var controlSetting))
            {
                var modeSetting = CurrentTheme.ModeSettings.FirstOrDefault(s => s.Key.ToString() == CurrentTheme.Name || s.Key == ModeType.Default);

                if (modeSetting.Value != null)
                {
                    controlSetting.ApplySettings(control, modeSetting.Value);
                }
            }
        }

        protected virtual void OnThemeChanged()
        {
            ThemeChanged?.Invoke(this, EventArgs.Empty);
        }

        

        public bool IsColorMatchingBackground(Color color, int tolerance = 10)
        {
            return ColorMatch(color, CurrentTheme.ModeSettings[ModeType.Default].BackColor, tolerance);
        }

        public bool IsColorMatchingForeground(Color color, int tolerance = 10)
        {
            return ColorMatch(color, CurrentTheme.ModeSettings[ModeType.Default].ForeColor, tolerance);
        }

        private bool ColorMatch(Color color1, Color color2, int tolerance)
        {
            return Math.Abs(color1.R - color2.R) <= tolerance
                && Math.Abs(color1.G - color2.G) <= tolerance
                && Math.Abs(color1.B - color2.B) <= tolerance;
        }

        public void SaveThemesToJson(string filePath)
        {
            var file = new ThemeFileConstructor(themes);
            var serializedThemes = JsonConvert.SerializeObject(file, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, serializedThemes);
        }

        public void LoadThemesFromJson(string filePath)
        {
            var serializedThemes = System.IO.File.ReadAllText(filePath);
            themes = JsonConvert.DeserializeObject<Dictionary<string, Theme>>(serializedThemes);
        }

        
    }
    public class Theme
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Dictionary<ModeType, ModeSettings> ModeSettings { get; } = new Dictionary<ModeType, ModeSettings>();
    }

    public class ControlSettings
    {
        public Dictionary<ModeType, ModeSettings> ModeSettings { get; } = new Dictionary<ModeType, ModeSettings>();

        public void ApplySettings(Control control, ModeSettings settings)
        {
            Console.WriteLine(control.Name + " - " + settings.BackColor, settings.ForeColor);


            control.BackColor = settings.BackColor;
            control.ForeColor = settings.ForeColor;
        }
    }

    public class ModeSettings
    {
        public Color BackColor { get; set; }
        public Color AccentColor { get; set; }
        public Color ForeColor { get; set; }
    }

    public enum ModeType
    {
        Default,
        Dark,
        Light,
    }
}
