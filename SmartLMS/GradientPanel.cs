using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class GradientPanel : Panel
{
    public Color ColorTop { get; set; } = Color.LightBlue;
    public Color ColorBottom { get; set; } = Color.DarkBlue;

    protected override void OnPaint(PaintEventArgs e)
    {
        LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, LinearGradientMode.Vertical);
        Graphics g = e.Graphics;
        g.FillRectangle(brush, this.ClientRectangle);
        base.OnPaint(e);
    }
}
