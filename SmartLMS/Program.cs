using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmartLMS.SettingsForm;

namespace SmartLMS
{
    internal static class Program
    {
        private static int userId;
        private static string fullName;

        // Used for applying theme before launching UI
        public class UserSettings
        {
            public string Theme { get; set; }
            public string FontSize { get; set; }
            public string Language { get; set; }
            public bool AutoBackup { get; set; }
            public bool ShowHints { get; set; }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string settingsPath = System.IO.Path.Combine(Application.StartupPath, "settings.txt");
            if (System.IO.File.Exists(settingsPath))
            {
                try
                {
                    var json = System.IO.File.ReadAllText(settingsPath);
                    var settings = Newtonsoft.Json.JsonConvert.DeserializeObject<UserSettings>(json);
                    if (settings != null)
                    {
                        AppSettings.Theme = settings.Theme ?? AppSettings.Theme;
                        AppSettings.FontSize = settings.FontSize ?? AppSettings.FontSize;
                        AppSettings.Language = settings.Language ?? AppSettings.Language;
                        AppSettings.AutoBackup = settings.AutoBackup;
                        AppSettings.ShowHints = settings.ShowHints;
                    }
                }
                catch
                {
                    // log or ignore error if settings file is corrupted
                }
            }

            Application.Run(new SplashScreenForm());
        }


        private static void LoadThemeFromFile()
        {
            try
            {
                string path = "settings.txt";
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var settings = JsonConvert.DeserializeObject<UserSettings>(json);
                    ThemeManager.CurrentTheme = settings.Theme;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading theme settings: " + ex.Message);
            }
        }
    }
}
