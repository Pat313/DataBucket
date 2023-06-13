using static DataBucket.UI.DrawingFunctions;

namespace DataBucket.UI
{
    public partial class ReleaseTitle : UserControl
    {
        public ReleaseTitle()
        {
            InitializeComponent();
        }

        public string Date
        {
            set { lblDate.Text = value; }
        }

        public string Version
        {
            set { lblVersion.Text = value; }
        }
    }
}
