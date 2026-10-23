using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentPanel : Panel
{
    public TransparentPanel()
    {
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = Color.FromArgb(200, 255, 255, 255); // Semi-transparent white

    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
