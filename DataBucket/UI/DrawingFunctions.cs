using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Reflection;

namespace DataBucket.UI
{
    public static class DrawingFunctions
    {
        #region Control extensions
        public static void DrawBadge(this DataGridView _, DataGridViewCellPaintingEventArgs e, byte columnIndex, string trueText, string falseText, Color trueColor, Color falseColor)
        {
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentBackground);

                bool? val = (bool?)e.Value;
                if (val.HasValue)
                {
                    string badgeText = val.Value ? trueText : falseText;
                    Color backColor = val.Value ? trueColor : falseColor;
                    Color foreColor = Color.FromArgb(backColor.R + 100, backColor.G + 100, backColor.B + 100);
                    using Font badgeFont = new("Calibri", 10f * e.Graphics.DpiY / 96f, FontStyle.Bold);

                    int textWidth = (int)Math.Round(TextRenderer.MeasureText(badgeText, badgeFont).Width * e.Graphics.DpiX / 96f);
                    int badgeHeight = (int)Math.Round(25f * e.Graphics.DpiY / 96f);
                    int cornerRadius = (int)Math.Round(20f * e.Graphics.DpiX / 96f);
                    int textHeight = TextRenderer.MeasureText(badgeText, badgeFont).Height;

                    Rectangle badgeRect = new(e.CellBounds.X + e.CellBounds.Width / 2 - textWidth / 2, e.CellBounds.Y + e.CellBounds.Height / 2 - badgeHeight / 2, textWidth, badgeHeight);

                    using GraphicsPath path = GetRoundedRectPath(badgeRect, cornerRadius);
                    using SolidBrush brush = new(backColor);
                    using StringFormat format = new() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(brush, path);
                    brush.Color = foreColor;
                    e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    e.Graphics.DrawString(badgeText, badgeFont, brush, badgeRect, format);
                }
                e.Handled = true;
            }
        }

        private static GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            path.AddLine(rect.Left + radius, rect.Top, rect.Right - radius, rect.Top);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddLine(rect.Right - radius, rect.Bottom, rect.Left + radius, rect.Bottom);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.AddLine(rect.Left, rect.Bottom - radius, rect.Left, rect.Top + radius);
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.CloseFigure();
            return path;
        }
        #endregion

        public static class AlterView
        {
            public static void SetDoubleBuffered(Control control)
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                                             BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                                             null, control, new object[] { true });

                //foreach (Control childControl in control.Controls)  SetDoubleBuffered(childControl);
            }
        }
    }
}
