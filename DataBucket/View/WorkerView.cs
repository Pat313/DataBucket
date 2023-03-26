using DataBucket._Base;

namespace DataBucket.View
{
    public partial class WorkerView : UserControl
    {
        public static WorkerView Instance { get; } = new WorkerView();
        private readonly Connection conn = Connection.Instance;

        public WorkerView()
        {
            InitializeComponent();
        }

        private async void WorkerView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            await conn.FillWorker(dgvWorker);
        }
    }
}
