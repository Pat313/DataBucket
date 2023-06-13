using Org.BouncyCastle.Asn1.Tsp;
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

        public static void DrawTag(Graphics graphics, Point location, char tagChar)
        {
            Size tagSize = new Size(125, 30);
            int cornerRadius = 15;

            string tagText;
            Color backColor;
            Color foreColor;

            if (tagInfoDict.TryGetValue(tagChar, out TagInfo tagInfo))
            {
                backColor = tagInfo.BackColor;
                foreColor = tagInfo.ForeColor;
                tagText = tagInfo.TagText;
            }
            else // Default
            {
                backColor = Color.LightGray;
                foreColor = Color.Black;
                tagText = "Ismeretlen";
            }

            Rectangle tagBounds = new Rectangle(location, tagSize);

            using Font tagFont = new("Calibri", 10f * graphics.DpiY / 96f, FontStyle.Bold);
            using GraphicsPath path = GetRoundedRectPath(tagBounds, cornerRadius);
            using SolidBrush backBrush = new SolidBrush(backColor);
            using SolidBrush foreBrush = new SolidBrush(foreColor);
            using StringFormat format = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillPath(backBrush, path);
            graphics.DrawString(tagText, tagFont, foreBrush, tagBounds, format);
        }

        private struct TagInfo
        {
            public Color BackColor { get; set; }
            public Color ForeColor { get; set; }
            public string TagText { get; set; }
        }

        private readonly static Dictionary<char, TagInfo> tagInfoDict = new Dictionary<char, TagInfo>()
        {
            { 'N', new TagInfo { BackColor = Color.FromArgb(70, 140, 70), TagText = "Újdonság", ForeColor = Color.FromArgb(220, 245, 220) } },
            { 'S', new TagInfo { BackColor = Color.FromArgb(175, 100, 40), TagText = "Biztonság", ForeColor = Color.FromArgb(255, 190, 128) } },
            { 'C', new TagInfo { BackColor = Color.FromArgb(140, 120, 60), TagText = "Változás", ForeColor = Color.FromArgb(255, 240, 150) } },
            { 'F', new TagInfo { BackColor = Color.FromArgb(80, 100, 140), TagText = "Javítva", ForeColor = Color.FromArgb(200, 220, 255) } },
            { 'A', new TagInfo { BackColor = Color.FromArgb(140, 120, 60), TagText = "Közlemény", ForeColor = Color.FromArgb(255, 235, 150) } },
            { 'I', new TagInfo { BackColor = Color.FromArgb(120, 40, 40), TagText = "Hiba", ForeColor = Color.FromArgb(255, 160, 160) } },
            { 'L', new TagInfo { BackColor = Color.FromArgb(100, 80, 140), TagText = "Könyvtárak" , ForeColor = Color.FromArgb(200, 180, 255) } },
            { 'D', new TagInfo { BackColor = Color.FromArgb(120, 40, 40), TagText = "Elavult", ForeColor = Color.FromArgb(255, 160, 160) } },
            { 'B', new TagInfo { BackColor = Color.FromArgb(120, 40, 40), TagText = "Fontos", ForeColor = Color.FromArgb(255, 160, 160) } },
        };


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
