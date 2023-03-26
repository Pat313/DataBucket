using DataBucket._Base;
using DataBucket.UI;

namespace DataBucket.View
{
    public partial class LiabilitiesView : UserControl
    {
        public static LiabilitiesView Instance { get; } = new();
        private readonly Connection conn = Connection.Instance;

        public LiabilitiesView()
        {
            InitializeComponent();
        }

        private async void LiabilitiesView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            await conn.FillLiabilities(dgvLiabilities, pgnLiabilities.PageLimit, pgnLiabilities.CurrentPage, dtpBeginDate, dtpEndDate, chbShowAll);

            btnRefresh.Click += btnRefresh_Click;
            dgvLiabilities.CellPainting += dgvLiabilities_CellPainting;
            chbShowAll.CheckedChanged += ChbShowAll_CheckedChanged;

            dtpBeginDate.ValueChanged += dtpBeginDate_ValueChanged;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;

            pgnLiabilities.PagingEvent += PgnLiabilities_PagingEvent;
        }

        private void dgvLiabilities_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            dgvLiabilities.DrawBadge(e, 6, "Fizetve", "Esedékes",
                Color.FromArgb(80, 130, 80), Color.FromArgb(130, 80, 80));
        }

        private async void LoadNextPage() => await conn.FillLiabilities(dgvLiabilities, pgnLiabilities.PageLimit, pgnLiabilities.CurrentPage, dtpBeginDate, dtpEndDate, chbShowAll);

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            pgnLiabilities.SetResults(conn.GetLiabilities(dtpBeginDate, dtpEndDate, chbShowAll));
            LoadNextPage();
        }

        private void ChbShowAll_CheckedChanged(object? sender, EventArgs e)
        {
            chbShowAll.Image = chbShowAll.Checked ? Properties.Resources.checkmark3 : Properties.Resources.crossmark3;
            LoadNextPage();
        }

        private void dtpBeginDate_ValueChanged(object? sender, EventArgs e) => btnRefresh.PerformClick();
        private void dtpEndDate_ValueChanged(object? sender, EventArgs e) => btnRefresh.PerformClick();

        private void PgnLiabilities_PagingEvent(object? sender, EventArgs e) => LoadNextPage();
    }
}
