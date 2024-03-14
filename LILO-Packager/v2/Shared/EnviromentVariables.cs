using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Shared
{
    public class EnviromentVariables
    {
        // Static
        public static string ApplicationDirectory { get => Application.ExecutablePath.Replace("crypterv2.exe", ""); }

        //Dynamik
        private const string FilePath = "objdt\\env.env";
        private Dictionary<string, string> variables;

        Image

        public EnviromentVariables()
        {
            LoadVariables();
        }

        public void SetVariable(string key, string value)
        {
            variables[key] = value;
            SaveVariables();
        }

        public string GetVariable(string key)
        {
            if (variables.TryGetValue(key, out string value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        public void DeleteVariable(string key)
        {
            if (variables.ContainsKey(key))
            {
                variables.Remove(key);
                SaveVariables();
            }
        }

        private void LoadVariables()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    variables = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    ConsoleManager.Instance().WriteLineWithColor("Successfully loaded all environment variables.");
                }
                else
                {
                    variables = new Dictionary<string, string>();
                    SetVariable("appDir", ApplicationDirectory);
                }
            }
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor($"Error loading environment variables: {ex.Message}");
                variables = new Dictionary<string, string>();
            }
        }

        private void SaveVariables()
        {
            try
            {
                string json = JsonConvert.SerializeObject(variables, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor($"Error saving environment variables: {ex.Message}");
            }
        }
    }
}
