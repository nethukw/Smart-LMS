using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartLMS
{
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

            // Apply colors recursively to controls
            ApplyColorsRecursive(form, backColor, foreColor);
        }

        private static void ApplyColorsRecursive(Control parent, Color back, Color fore)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.BackColor = back;
                ctrl.ForeColor = fore;

                if (ctrl.HasChildren)
                    ApplyColorsRecursive(ctrl, back, fore);
            }
        }

    }
}