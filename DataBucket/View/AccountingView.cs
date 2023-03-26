using DataBucket._Base;

namespace DataBucket.View
{
    public partial class AccountingView : UserControl
    {
        public static AccountingView Instance { get; } = new();
        private readonly Connection conn = Connection.Instance;

        private readonly DateTime currentDate = DateTime.Today;

        public AccountingView()
        {
            InitializeComponent();
        }

        private async void AccountingView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cmbWorker.DataSource = await conn.FillComboBox("worker.fullName");

            cmbWorker.SelectedIndexChanged += cmbWorker_SelectedIndexChanged;
            btnRefresh.Click += btnRefresh_Click;

            rdbToday.Click += rdbToday_Click;
            rdbYesterday.Click += rdbYesterday_Click;
            rdbThisWeek.Click += rdbThisWeek_Click;
            rdbLastWeek.Click += rdbLastWeek_Click;
            rdbThisMonth.Click += rdbThisMonth_Click;
            rdbLastMonth.Click += rdbLastMonth_Click;
            rdbThisYear.Click += rdbThisYear_Click;
            rdbLastYear.Click += rdbLastYear_Click;
            rdbAll.Click += rdbAll_Click;

            pgnAll.PagingEvent += PgnAll_PagingEvent;
            pgnDaily.PagingEvent += PgnDaily_PagingEvent;
            pgnMonthly.PagingEvent += PgnMonthly_PagingEvent;

            dtpBeginDate.ValueChanged += dtpBeginDate_ValueChanged;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
        }

        //private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e) { if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage(); }
        private void cmbWorker_SelectedIndexChanged(object? sender, EventArgs e) => btnRefresh.PerformClick();

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            /*Task<long>[] displayed = {
                conn.GetAccountingAll(cmbWorker, dtpBeginDate, dtpEndDate),
                conn.GetAccountingDaily(cmbWorker, dtpBeginDate, dtpEndDate),
                conn.GetAccountingMonthly(cmbWorker, dtpBeginDate, dtpEndDate)
            };*/

            pgnAll.SetResults(conn.GetAccountingAll(cmbWorker, dtpBeginDate, dtpEndDate));
            pgnDaily.SetResults(conn.GetAccountingDaily(cmbWorker, dtpBeginDate, dtpEndDate));
            pgnMonthly.SetResults(conn.GetAccountingDaily(cmbWorker, dtpBeginDate, dtpEndDate));
            //pgnMonthly.TotalRows = await conn.GetAccountingMonthly(cmbWorker, dtpBeginDate, dtpEndDate);

            LoadNextPageAll();
            LoadNextPageDaily();
            LoadNextPageMonthly();

            if (dgvAll.Columns.Count > 0)
            {
                dgvAll.Columns[0].DefaultCellStyle.Format = "MM. dd. (dddd)";
                dgvDaily.Columns[0].DefaultCellStyle.Format = "M";
                dgvMonthly.Columns[0].DefaultCellStyle.Format = "yyyy MMMM";
            }
        }

        private async void LoadNextPageAll() =>
            await conn.FillAccountingAll(dgvAll, pgnAll.PageLimit, pgnAll.CurrentPage, cmbWorker, dtpBeginDate, dtpEndDate);

        private async void LoadNextPageDaily() =>
            await conn.FillAccountingDaily(dgvDaily, pgnDaily.PageLimit, pgnDaily.CurrentPage, cmbWorker, dtpBeginDate, dtpEndDate);

        private async void LoadNextPageMonthly() =>
            await conn.FillAccountingMonthly(dgvMonthly, pgnMonthly.PageLimit, pgnMonthly.CurrentPage, cmbWorker, dtpBeginDate, dtpEndDate);

        private void PgnAll_PagingEvent(object? sender, EventArgs e) => LoadNextPageAll();
        private void PgnDaily_PagingEvent(object? sender, EventArgs e) => LoadNextPageDaily();
        private void PgnMonthly_PagingEvent(object? sender, EventArgs e) => LoadNextPageMonthly();

        private void dtpBeginDate_ValueChanged(object? sender, EventArgs e) => btnRefresh.PerformClick();
        private void dtpEndDate_ValueChanged(object? sender, EventArgs e) => btnRefresh.PerformClick();

        private void ResetDateSelectors(RadioButton rdb)
        {
            foreach (RadioButton btn in pnlDateSelectors.Controls.OfType<RadioButton>())
            {
                btn.ForeColor = Color.FromArgb(180, 180, 180);
                btn.Checked = false;
            }
            rdb.Checked = true;
            rdb.ForeColor = Color.Gainsboro;
        }

        private void rdbToday_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = currentDate;
            dtpEndDate.Value = currentDate;
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }

        private void rdbYesterday_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = currentDate.AddDays(-1);
            dtpEndDate.Value = currentDate.AddDays(-1);
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }

        private void rdbThisWeek_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = currentDate.AddDays(-(int)currentDate.DayOfWeek + 1);
            dtpEndDate.Value = dtpBeginDate.Value.AddDays(7).AddSeconds(-1);
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }

        private void rdbLastWeek_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = currentDate.AddDays(-(int)currentDate.DayOfWeek - 6);
            dtpEndDate.Value = dtpBeginDate.Value.AddDays(7).AddSeconds(-1);
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }

        private void rdbThisMonth_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = new DateTime(currentDate.Year, currentDate.Month, 1);
            dtpEndDate.Value = new DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month));
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }

        private void rdbLastMonth_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(-1);
            dtpEndDate.Value = new DateTime(currentDate.Year, currentDate.Month, 1).AddDays(-1);
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }

        private void rdbThisYear_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = new DateTime(currentDate.Year, 1, 1);
            dtpEndDate.Value = new DateTime(currentDate.Year, 12, 31);
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }

        private void rdbLastYear_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = new DateTime(currentDate.Year - 1, 1, 1);
            dtpEndDate.Value = new DateTime(currentDate.Year - 1, 12, 31);
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }

        private void rdbAll_Click(object sender, EventArgs e)
        {
            ResetDateSelectors((RadioButton)sender);
            dtpBeginDate.Value = new DateTime(2015, 1, 1);
            dtpEndDate.Value = new DateTime(2030, 12, 31);
            //if (isRefreshing) btnRefresh.PerformClick(); else LoadNextPage();
            btnRefresh.PerformClick();
        }
    }
}
