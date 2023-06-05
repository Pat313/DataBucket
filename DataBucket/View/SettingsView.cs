using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBucket.View
{
    public partial class SettingsView : UserControl
    {
        public static SettingsView Instance { get; } = new();

        public SettingsView()
        {
            InitializeComponent();
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {
            //ConfigurationManager.ConnectionStrings["con_1"].ConnectionString;
        }
    }
}
