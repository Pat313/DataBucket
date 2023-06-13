using DataBucket._Base;

namespace DataBucket.View
{
    public partial class SettingsView : UserControl
    {
        public static SettingsView Instance { get; } = new();
        private readonly Connection conn = Connection.Instance;

        public SettingsView()
        {
            InitializeComponent();
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {
            cmbServerIP.TextChanged += cmbServerIP_TextChanged;
            btnDefault.Click += btnDefault_Click;
            btnSave.Click += btnSave_Click;

            btnDefault.PerformClick();
        }

        private void btnDefault_Click(object? sender, EventArgs e)
        {
            cmbServerIP.SelectedText = Properties.Settings.Default["serverChosen"].ToString();
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            Properties.Settings.Default["serverChosen"] = cmbServerIP.Text;
        }

        private void cmbServerIP_TextChanged(object? sender, EventArgs e)
        {
            conn.Reset(cmbServerIP.Text);
        }
    }
}
