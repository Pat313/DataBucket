using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBucket
{
    public partial class LiabilitiesView : UserControl
    {
        private static LiabilitiesView instance;

        public static LiabilitiesView Instance
        {
            get => instance ?? (instance = new LiabilitiesView());
        }

        private readonly Connection conn = Connection.Instance;

        public LiabilitiesView()
        {
            InitializeComponent();
        }

        private async void LiabilitiesView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            await conn.FillLiabilities(dgvLiabilities);
        }
    }
}
