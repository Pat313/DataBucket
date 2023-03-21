using System.ComponentModel;

namespace DataBucket.UI
{
    [Designer(typeof(System.Windows.Forms.Design.ControlDesigner))]
    public class CheckBoxEx : CheckBox
    {
        private Color _checkColor = Color.DodgerBlue;

        public Color CheckColor
        {
            get { return _checkColor; }
            set { _checkColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Checked)
            {
                using (Brush brush = new SolidBrush(_checkColor))
                {
                    int padding = 2;
                    int checkSize = Height - 2 * padding;
                    int x = padding;
                    int y = padding;

                    e.Graphics.FillRectangle(brush, x, y, checkSize, checkSize);
                }
            }
        }
    }
}