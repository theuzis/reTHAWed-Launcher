using System.Drawing;
using System.Windows.Forms;

namespace NEWRTL
{
    public class BorderlessGroupBox : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            // Only draw the text, skip drawing the border
            Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
            Rectangle textRect = new Rectangle(6, 0, textSize.Width + 2, textSize.Height);

            // Fill background
            using (Brush backBrush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(backBrush, this.ClientRectangle);
            }

            // Draw the text manually
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, textRect, this.ForeColor);
        }
    }
}