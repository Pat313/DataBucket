using static DataBucket.UI.DrawingFunctions;

namespace DataBucket.UI
{
    public partial class ReleaseNote : UserControl
    {
        public ReleaseNote()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawTag(e.Graphics, new Point(10, 10), Tag);
        }

        private char tag;
        public char Tag
        {
            private get { return tag; }
            set { tag = value; }
        }

        public string Note
        {
            set 
            {
                txtNote.Text = value;
                Height += ((int)Math.Ceiling((double)value.Length / 37) - 1) * 24;
            }
        }
    }
}
