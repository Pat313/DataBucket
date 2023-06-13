using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataBucket
{
    public class TextBoxEx : TextBox
    {
        const int WM_NCPAINT = 0x85;
        const uint RDW_INVALIDATE = 0x1;
        const uint RDW_IUPDATENOW = 0x100;
        const uint RDW_FRAME = 0x400;
        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
        Color borderColor = Color.Blue;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent &&
                BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D)
            {
                var hdc = GetWindowDC(this.Handle); using (var g = Graphics.FromHdcInternal(hdc)) 
                { 
                    using (var p = new Pen(BorderColor)) g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1)); 
                    using (var b = new Pen(BackColor)) g.DrawRectangle(b, new Rectangle(1, 1, Width - 3, Height - 3)); 
                } 
                ReleaseDC(this.Handle, hdc);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                   RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen penBorder = new Pen(Color.Gray, 1);
            Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            e.Graphics.DrawRectangle(penBorder, rectBorder);

            Rectangle textRec = new Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            TextRenderer.DrawText(e.Graphics, Text, this.Font, textRec, this.ForeColor, this.BackColor, TextFormatFlags.Default);
        }
    }
}