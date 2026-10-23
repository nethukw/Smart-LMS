using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientButton : Button
{
    public Color ColorTop { get; set; } = Color.MediumSlateBlue;
    public Color ColorBottom { get; set; } = Color.MediumPurple;

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent); // Call base first

        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               this.ColorTop,
                                                               this.ColorBottom,
                                                               90F))
        {
            pevent.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    public GradientButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.ForeColor = Color.White;
    }
}
