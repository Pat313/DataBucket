using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBucket
{
    public partial class WorkerView : UserControl
    {
        private static WorkerView instance;

        public static WorkerView Instance
        {
            get => instance ?? (instance = new WorkerView());
        }

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
