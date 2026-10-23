using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;


namespace SmartLMS
{
    public partial class SettingsForm : Form
    {
        private string settingsPath;
        public SettingsForm()
        {
            InitializeComponent();
            settingsPath = Path.Combine(Application.StartupPath, "settings.txt");

            InitializeComboBoxes();
            LoadSettingsToControls();
            AppSettings.ApplyToForm(this);
        }

        private void InitializeComboBoxes()
        {
            if (cmbTheme.Items.Count == 0)
                cmbTheme.Items.AddRange(new object[] { "Light", "Dark" });

            if (cmbFontSize.Items.Count == 0)
                cmbFontSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });

            if (cmbLanguage.Items.Count == 0)
                cmbLanguage.Items.AddRange(new object[] { "English", "Sinhala", "Tamil" });
        }

        private void LoadSettingsToControls()
        {
            if (File.Exists(settingsPath))
            {
                try
                {
                    var json = File.ReadAllText(settingsPath);
                    var settings = JsonConvert.DeserializeObject<UserSettings>(json);
                    if (settings != null)
                    {
                        AppSettings.Theme = settings.Theme ?? AppSettings.Theme;
                        AppSettings.FontSize = settings.FontSize ?? AppSettings.FontSize;
                        AppSettings.Language = settings.Language ?? AppSettings.Language;
                        AppSettings.AutoBackup = settings.AutoBackup;
                        AppSettings.ShowHints = settings.ShowHints;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading settings: " + ex.Message);
                }
            }

            cmbTheme.SelectedItem = AppSettings.Theme;
            if (cmbTheme.SelectedItem == null && cmbTheme.Items.Count > 0) cmbTheme.SelectedIndex = 0;

            cmbFontSize.SelectedItem = AppSettings.FontSize;
            if (cmbFontSize.SelectedItem == null && cmbFontSize.Items.Count > 0) cmbFontSize.SelectedIndex = 1;

            cmbLanguage.SelectedItem = AppSettings.Language;
            if (cmbLanguage.SelectedItem == null && cmbLanguage.Items.Count > 0) cmbLanguage.SelectedIndex = 0;

            chkAutoBackup.Checked = AppSettings.AutoBackup;
            chkShowHints.Checked = AppSettings.ShowHints;
        }


        public static class ThemeManager
        {
            public static string CurrentTheme = "Light";

            public static void ApplyTheme(Form form)
            {
                Color backColor, foreColor;

                switch (CurrentTheme)
                {
                    case "Dark":
                        backColor = Color.FromArgb(45, 45, 48);
                        foreColor = Color.White;
                        break;
                    case "Light":
                        backColor = Color.White;
                        foreColor = Color.Black;
                        break;
                    default:
                        backColor = SystemColors.Control;
                        foreColor = SystemColors.ControlText;
                        break;
                }

                form.BackColor = backColor;
                foreach (Control ctrl in form.Controls)
                {
                    ctrl.ForeColor = foreColor;
                    ctrl.BackColor = backColor;
                }
            }
        }

        public class UserSettings
        {
            public string Theme { get; set; }
            public string FontSize { get; set; }
            public string Language { get; set; }
            public bool AutoBackup { get; set; }
            public bool ShowHints { get; set; }
        }

        public void SaveSettings()
        {
            var settings = new UserSettings()
            {
                Theme = cmbTheme.SelectedItem?.ToString() ?? "Light",
                FontSize = cmbFontSize.SelectedItem?.ToString() ?? "Medium",
                Language = cmbLanguage.SelectedItem?.ToString() ?? "English",
                AutoBackup = chkAutoBackup.Checked,
                ShowHints = chkShowHints.Checked
            };

            string json = JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(settingsPath, json);

            // update global runtime settings
            AppSettings.Theme = settings.Theme;
            AppSettings.FontSize = settings.FontSize;
            AppSettings.Language = settings.Language;
            AppSettings.AutoBackup = settings.AutoBackup;
            AppSettings.ShowHints = settings.ShowHints;

            // apply to all open forms immediately
            foreach (Form f in Application.OpenForms)
                AppSettings.ApplyToForm(f);

            AppSettings.RaiseSettingsChanged();

            MessageBox.Show("Settings saved!", "Success");
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

                    if (settings != null && !string.IsNullOrEmpty(settings.Theme))
                    {
                        ThemeManager.CurrentTheme = settings.Theme;
                    }
                    else
                    {
                        ThemeManager.CurrentTheme = "Light"; // Default theme
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading theme settings: " + ex.Message);
                ThemeManager.CurrentTheme = "Light"; // Safe fallback
            }
        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadThemeFromFile();
            ThemeManager.ApplyTheme(this);

            if (cmbTheme.Items.Count > 0 && cmbTheme.SelectedIndex == -1)
                cmbTheme.SelectedIndex = 0;

            if (cmbFontSize.Items.Count > 0 && cmbFontSize.SelectedIndex == -1)
                cmbFontSize.SelectedIndex = 0;

            if (cmbLanguage.Items.Count > 0 && cmbLanguage.SelectedIndex == -1)
                cmbLanguage.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbTheme.SelectedIndex = 0;
            cmbFontSize.SelectedIndex = 1;
            cmbLanguage.SelectedIndex = 0;
            chkAutoBackup.Checked = false;
            chkShowHints.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

