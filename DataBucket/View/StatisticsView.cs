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
    public partial class StatisticsView : UserControl
    {
        private static StatisticsView instance;

        public static StatisticsView Instance
        {
            get => instance ?? (instance = new StatisticsView());
        }

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
