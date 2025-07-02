using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace SSA_B_Canteen
{
    [ToolboxItem(true)]
    public class RoundedPanel : Panel
    {
        [Category("Appearance")]
        [Description("The radius for the panel's rounded corners.")]
        public int BorderRadius { get; set; } = 20;

        [Category("Appearance")]
        [Description("The color of the panel's border.")]
        public Color BorderColor { get; set; } = Color.Black;

        [Category("Appearance")]
        [Description("The thickness of the panel's border.")]
        public int BorderSize { get; set; } = 1;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int borderOffset = BorderSize / 2;
            Rectangle rect = new Rectangle(
                borderOffset,
                borderOffset,
                this.Width - BorderSize,
                this.Height - BorderSize
            );

            using (GraphicsPath path = GetRoundRectPath(rect, BorderRadius))
            {
                this.Region = new Region(path);
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }


        private GraphicsPath GetRoundRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
