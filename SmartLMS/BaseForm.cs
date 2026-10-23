using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLMS
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            AppSettings.ApplyToForm(this);
            AppSettings.SettingsChanged += OnSettingsChanged;
        }

        private void OnSettingsChanged(object sender, EventArgs e)
        {
            if (IsDisposed) return;
            if (InvokeRequired)
                Invoke(new Action(() => AppSettings.ApplyToForm(this)));
            else
                AppSettings.ApplyToForm(this);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            AppSettings.SettingsChanged -= OnSettingsChanged;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
