using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static global::SmartLMS.SettingsForm;

namespace SmartLMS
{
  
        public static class AppSettings
        {
            public static string Theme { get; set; } = "Light";
            public static string FontSize { get; set; } = "Medium";
            public static string Language { get; set; } = "English";
            public static bool AutoBackup { get; set; } = false;
            public static bool ShowHints { get; set; } = true;

            public static event EventHandler SettingsChanged;

            public static void RaiseSettingsChanged() => SettingsChanged?.Invoke(null, EventArgs.Empty);

            public static void ApplyToForm(Form form)
            {
                if (form == null) return;

                // Theme
                ThemeManager.CurrentTheme = Theme;
                ThemeManager.ApplyTheme(form);

                // Font size
                float size = GetFontSizeValue();
                SetFontSizeRecursive(form, size);

                // Apply to MenuStrip/ToolStrip items if any
                foreach (MenuStrip ms in form.Controls.OfType<MenuStrip>())
                    ApplyToolStripItems(ms.Items, size);
            }

            private static float GetFontSizeValue()
            {
                switch (FontSize)
                {
                    case "Small":
                        return 8f;
                    case "Medium":
                        return 10f;
                    case "Large":
                        return 12f;
                    default:
                        return 10f;
                }
            }
            

            private static void SetFontSizeRecursive(Control parent, float size)
            {
                parent.Font = new Font(parent.Font.FontFamily, size, parent.Font.Style);
                foreach (Control c in parent.Controls)
                    SetFontSizeRecursive(c, size);
            }

            private static void ApplyToolStripItems(ToolStripItemCollection items, float size)
            {
                foreach (ToolStripItem item in items)
                {
                    item.Font = new Font(item.Font.FontFamily, size, item.Font.Style);
                    if (item is ToolStripDropDownItem dd && dd.DropDownItems.Count > 0)
                        ApplyToolStripItems(dd.DropDownItems, size);
                }
            }
        }
    }


