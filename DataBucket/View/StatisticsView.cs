using DataBucket._Base;
using DataBucket.View;

namespace DataBucket
{
    public partial class StatisticsView : UserControl
    {
        public static StatisticsView Instance { get; } = new();
        private readonly Connection conn = Connection.Instance;

        public StatisticsView()
        {
            InitializeComponent();
        }

        private void StatisticsView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
