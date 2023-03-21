using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataBucket.Presenter;
using DataBucket.UI;

namespace DataBucket.View
{
    public partial class WorkView : UserControl
    {
        private readonly Connection conn = Connection.Instance;

        private static WorkView instance;

        public static WorkView Instance => instance ??= new WorkView();

        private CheckBox checkBoxHeader;

        public WorkView()
        {
            InitializeComponent();
        }

        private async void WorkView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //btnStartServer.PerformClick(); // to main form
            //cldWork.Header.BackColor1 = Color.DarkOrchid;
            //cldWork.SelectDate(DateTime.Today);
            List<object> list = await conn.FillComboBox("worker.fullName");
            list.Insert(0, "(mindenki)");
            cmbRepairman.DataSource = list;
            cmbConcomitant.BindingContext = new BindingContext();
            cmbConcomitant.DataSource = list;

            cldWork.DateSelected += cldWork_DateSelected;
            cmbRepairman.SelectedIndexChanged += cmbRepairman_SelectedIndexChanged;
            cmbConcomitant.SelectedIndexChanged += cmbConcomitant_SelectedIndexChanged;
            btnRefresh.Click += btnRefresh_Click;
            cmsItemRefresh.Click += btnRefresh_Click;
            btnImages.Click += btnImages_Click;
            cmsItemImages.Click += btnImages_Click;
            btnAdd.Click += btnAdd_Click;
            cmsItemAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            cmsItemEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            cmsItemDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            //btnStartServer.Click += btnStartServer_Click; // to main form
            //dgvWork.MouseClick += dgvWork_MouseClick; // intercepts contextmenu
            dgvWork.MouseDown += dgvWork_MouseDown;
            dgvWork.CellPainting += dgvWork_CellPainting;
            dgvWork.SizeChanged += dgvWork_SizeChanged;
            pgnWork.PagingEvent += PgnWork_PagingEvent;
            //dgvWork.CellContentClick += dgvWork_CellContentClick;
            txtQuery.KeyDown += txtQuery_KeyDown;
            //dgvWork.ColumnHeaderMouseClick += dgvWork_ColumnHeaderMouseClick; // header of badge columns not filterable
            btnRelaxed.Click += btnRelaxed_Click;
            cmsItemRelaxed.Click += btnRelaxed_Click;
            btnRegular.Click += btnRegular_Click;
            cmsItemRegular.Click += btnRegular_Click;
            btnCompact.Click += btnCompact_Click;
            cmsItemCompact.Click += btnCompact_Click;
            tipWork.Draw += tipWork_Draw;
            //dgvWork.DataBindingComplete += dgvWork_DataBindingComplete;
            /*dgvWork.DataBindingComplete += (s, a) =>
            {
                if (dgvWork.Columns["Törlesztés"] is DataGridViewCheckBoxColumn)
                {
                    int index = dgvWork.Columns["Törlesztés"].Index;
                    dgvWork.Columns.RemoveAt(index);
                    dgvWork.Columns.Insert(index, new BadgeColumn());
                    dgvWork.Columns[index].DataPropertyName = "Törlesztés";
                    dgvWork.Columns[index].HeaderText = "Törlesztés";
                    dgvWork.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            };*/
        }

        //private void addForm_Closed(object sender, FormClosedEventArgs e) => btnRefresh.PerformClick();

        //private void editForm_Closed(object sender, FormClosedEventArgs e) => btnRefresh.PerformClick();

        private void cldWork_DateSelected(object sender, DateRangeEventArgs e) => btnRefresh.PerformClick();
        private void cmbRepairman_SelectedIndexChanged(object sender, EventArgs e) => btnRefresh.PerformClick();
        private void cmbConcomitant_SelectedIndexChanged(object sender, EventArgs e) => btnRefresh.PerformClick();

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cldWork.SelectionRange == null)
            {
                cldWork.SelectionStart = DateTime.Today;
                cldWork.SelectionEnd = DateTime.Today;
                MessageBox.Show("Nem adtál meg dátumot, így a mai nap lett automatikusan kiválasztva", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cmbRepairman.SelectedIndex == 0 && cmbConcomitant.SelectedIndex == 0)
            {
                pgnWork.SetResults(conn.GetWorkAll(cldWork));
                await conn.FillWorkAll(dgvWork, pgnWork.PageLimit, pgnWork.CurrentPage, cldWork);
            }
            else if (cmbRepairman.SelectedIndex > 0 && cmbConcomitant.SelectedIndex > 0)
            {
                pgnWork.SetResults(conn.GetWork(cldWork, cmbRepairman, cmbConcomitant));
                await conn.FillWork(dgvWork, pgnWork.PageLimit, pgnWork.CurrentPage, cldWork, cmbRepairman, cmbConcomitant);
            }
            else
            {
                pgnWork.SetResults(conn.GetWorkByWorker(cldWork, cmbRepairman.SelectedIndex > 0 ? cmbRepairman : cmbConcomitant));
                await conn.FillWorkByWorker(dgvWork, pgnWork.PageLimit, pgnWork.CurrentPage, cldWork, cmbRepairman.SelectedIndex > 0 ? cmbRepairman : cmbConcomitant /*?? cmbRepairman*/);
            }

            if (dgvWork.Columns.Count == 13)
            {
                using (DataGridViewCheckBoxColumn chkBoxColumn = new DataGridViewCheckBoxColumn())
                {
                    chkBoxColumn.HeaderText = "";
                    //chkBoxColumn.Frozen = true;
                    chkBoxColumn.CellTemplate = new DataGridViewCheckBoxCell();
                    chkBoxColumn.ReadOnly = false;
                    //chkBoxColumn.Width = 30;
                    dgvWork.Columns.Insert(0, chkBoxColumn);
                }

                for (int i = 2; i < 13; i++) dgvWork.Columns[i].ReadOnly = true;

                dgvWork.Columns[1].Visible = false;
                dgvWork.Columns[13].Visible = false;
                dgvWork.Columns[0].Width = 30;
            }
        }

        private async void LoadPage()
        {
            if (cmbRepairman.SelectedIndex == 0 && cmbConcomitant.SelectedIndex == 0)
                await conn.FillWorkAll(dgvWork, pgnWork.PageLimit, pgnWork.CurrentPage, cldWork);
            else if (cmbRepairman.SelectedIndex > 0 && cmbConcomitant.SelectedIndex > 0)
                await conn.FillWork(dgvWork, pgnWork.PageLimit, pgnWork.CurrentPage, cldWork, cmbRepairman, cmbConcomitant);
            else
                await conn.FillWorkByWorker(dgvWork, pgnWork.PageLimit, pgnWork.CurrentPage, cldWork, cmbRepairman.SelectedIndex > 0 ? cmbRepairman : cmbConcomitant /*?? cmbRepairman*/);
        }

        private void PgnWork_PagingEvent(object sender, EventArgs e) => LoadPage();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cldWork.SelectionRange.Start != cldWork.SelectionRange.End)
            {
                cldWork.SelectionStart = DateTime.Today;
                cldWork.SelectionEnd = DateTime.Today;
                MessageBox.Show("Nem adtál meg dátumot, így a mai nap lett automatikusan kiválasztva", "Sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (FormAdd formAdd = new FormAdd())
            {
                //formAdd.FormClosed += addForm_Closed;
                formAdd.SelectedDate = cldWork.SelectionStart;
                formAdd.SelectedRepairman = cmbRepairman.SelectedIndex != 0 ? cmbRepairman.SelectedIndex - 1 : cmbRepairman.SelectedIndex;
                formAdd.SelectedConcomitant = cmbConcomitant.SelectedIndex != 0 ? cmbConcomitant.SelectedIndex - 1 : cmbConcomitant.SelectedIndex;
                DialogResult result = formAdd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Refresh();
                    //dgvWork.Sort(dgvWork.Columns[2], ListSortDirection.Ascending);
                    //dgvWork.Refresh();
                    //btnRefresh.PerformClick();
                    LoadPage();
                }
                //formAdd.FormClosed -= addForm_Closed;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWork.SelectedRows.Count == 0)
            {
                MessageBox.Show("A szerkesztéshez előbb jelölj ki egy sort", "Sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (dgvWork.SelectedRows.Count > 1)
            {
                MessageBox.Show("Egyszerre nem szerkeszthetsz több munkát", "Sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (FormEdit formEdit = new FormEdit((int)dgvWork.SelectedCells[1].Value))
            {
                //formEdit.FormClosed += editForm_Closed;
                DialogResult result = formEdit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Refresh();
                    //dgvWork.Sort(dgvWork.Columns[2], ListSortDirection.Ascending);
                    //dgvWork.Refresh();
                    //btnRefresh.PerformClick();
                    LoadPage();
                }
                //formEdit.FormClosed -= editForm_Closed;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWork.SelectedRows.Count == 0)
            {
                MessageBox.Show("A törléshez előbb jelölj ki egy vagy több sort", "Sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<KeyValuePair<int, string>> selected = new List<KeyValuePair<int, string>>();

            foreach (DataGridViewRow row in dgvWork.SelectedRows)
                selected.Add(new KeyValuePair<int, string>((int)row.Cells[1].Value, (string)row.Cells[3].Value));

            DialogResult result = MessageBox.Show("Biztosan törlöd az alábbi munkákat?\n" +
                $"{string.Join("\n", selected.Select(i => i.Value).ToList().Take(5))}\n{(selected.Count > 5 ? "...\n" : "")}" +
                $"Összesen {selected.Count} kerül majd törlésre.",
                "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await conn.DeleteWork(selected.Select(i => i.Key).ToList());
                //btnRefresh.PerformClick();
                LoadPage();
                //dgvWork.Sort(dgvWork.Columns[2], ListSortDirection.Ascending);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dgvWork.SelectedRows.Count == 0 || txtQuery.TextLength == 0)
                return;

            dgvWork.Columns[0].Visible = false;
            dgvWork.Columns[1].Visible = true;
            dgvWork.Columns[9].Visible = false;

            dgvWork.Sort(dgvWork.Columns[2], ListSortDirection.Ascending);

            SetStatusColor();
        }

        private void dgvWork_Sorted(object sender, EventArgs e)
        {
            //SetStatusColor();
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            if (dgvWork.SelectedRows.Count != 1)
            {
                MessageBox.Show("A csatolt képek betöltéséhez jelölj ki egy adott munkát");
                return;
            }

            if (flpImages.Controls.Count != 0)
                foreach (SignalPicture pic in flpImages.Controls.OfType<SignalPicture>())
                {
                    pic.MouseClickEvent -= SignalPicture_MouseClick;
                    pic.Dispose();
                }

            //flpImages.Controls.Clear();
            flpImages.SuspendLayout();
            flpImages.Controls.AddRange(dgvWork.SelectedCells[13].Value.ToString().Split('|')
                .Select(x => new SignalPicture { ImageLocation = Path.Combine(Settings.signalPath, x + ".jpeg") }).ToArray());
            flpImages.ResumeLayout();

            if (flpImages.Controls.Count != 0)
                foreach (SignalPicture pic in flpImages.Controls.OfType<SignalPicture>())
                    pic.MouseClickEvent += SignalPicture_MouseClick;
        }

        private void dgvWork_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right) dgvWork.ClearSelection();
        }

        private void dgvWork_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvWork.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell || hit.Type == DataGridViewHitTestType.RowHeader)
                {
                    dgvWork.CurrentCell = dgvWork[2, hit.RowIndex];
                    dgvWork.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SetStatusColor()
        {
            string str = string.Empty;
            foreach (DataGridViewRow row in dgvWork.Rows)
            {
                if (row.Cells[9].Value != null)
                    str = row.Cells[9].Value.ToString();

                if (str.Equals("felvéve"))
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220, 220);
                else if (str.Equals("kiadva"))
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220, 0);
                else if (str.Equals("lemondva"))
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 207, 102, 121);
            }
        }

        private void SignalPicture_MouseClick(object sender, EventArgs e)
        {
            foreach (SignalPicture pic in flpImages.Controls.OfType<SignalPicture>())
            {
                if (pic == (SignalPicture)sender)
                    pic.BorderColor = Color.FromArgb(140, 100, 180);
                else
                    pic.BorderColor = Color.FromArgb(70, 70, 70);
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            dgvWork.EndEdit();

            foreach (DataGridViewRow row in dgvWork.Rows)
                if (row.Cells[0] is DataGridViewCheckBoxCell checkBoxCell)
                    checkBoxCell.Value = (sender as CheckBox).Checked;
        }

        private bool IsHeaderChecked()
        {
            bool isChecked = true;

            foreach (DataGridViewRow row in dgvWork.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                //if (checkBoxCell != null)
                if (!Convert.ToBoolean(checkBoxCell?.Value))
                {
                    isChecked = false;
                    break;
                }
            }

            return isChecked;
        }

        private void dgvWork_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgvWork.Columns.Count == 13) return;

            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                e.PaintBackground(e.CellBounds, true);
                e.PaintContent(e.CellBounds);

                if (checkBoxHeader == null)
                {
                    checkBoxHeader = new CheckBox();
                    checkBoxHeader.Size = new Size(16, 16);
                    checkBoxHeader.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                    ((DataGridView)sender).Controls.Add(checkBoxHeader);
                }

                checkBoxHeader.Checked = IsHeaderChecked();
                checkBoxHeader.Location = new Point(e.CellBounds.X + (e.CellBounds.Width - checkBoxHeader.Width) / 2,
                                                    e.CellBounds.Y + (e.CellBounds.Height - checkBoxHeader.Height) / 2);

                e.Handled = true;
            }

            DrawBadge(e, 10, "Utalás", "Készpénz",
                Color.FromArgb(50, 150, 150), Color.FromArgb(150, 150, 50),
                Color.FromArgb(150, 230, 230), Color.FromArgb(230, 230, 150));
            DrawBadge(e, 11, "Van számla", "Nincs számla",
                Color.FromArgb(50, 50, 150), Color.FromArgb(150, 50, 150),
                Color.FromArgb(150, 150, 230), Color.FromArgb(230, 150, 230));
            DrawBadge(e, 12, "Fizetett", "Nem fizetett",
                Color.FromArgb(50, 150, 50), Color.FromArgb(150, 50, 50),
                Color.FromArgb(150, 230, 150), Color.FromArgb(230, 150, 130));
        }

        private void DrawBadge(DataGridViewCellPaintingEventArgs e, int columnIndex, string trueText, string falseText, Color trueBack, Color falseBack, Color trueFont, Color falseFont)
        {
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentBackground);

                var val = e.Value as bool?;
                if (val.HasValue)
                {
                    var badgeText = val.Value ? trueText : falseText;
                    var badgeBackColor = val.Value ? trueBack : falseBack;
                    var badgeForeColor = val.Value ? trueFont : falseFont;
                    var badgeFont = new Font("Calibri", 14f, FontStyle.Regular);
                    var cornerRadius = 20;

                    var textWidth = TextRenderer.MeasureText(badgeText, badgeFont).Width;
                    var badgeHeight = 40;

                    var badgeRect = new Rectangle(e.CellBounds.X + e.CellBounds.Width / 2 - textWidth / 2, e.CellBounds.Y + e.CellBounds.Height / 2 - badgeHeight / 2, textWidth, badgeHeight);
                    //var badgeRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y + e.CellBounds.Height / 2 - badgeHeight / 2, textWidth, badgeHeight);

                    using (var path = GetRoundedRectPath(badgeRect, cornerRadius))
                    {
                        using (var brush = new SolidBrush(badgeBackColor))
                        {
                            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                            e.Graphics.FillPath(brush, path);
                        }
                        using (var brush = new SolidBrush(badgeForeColor))
                        {
                            var format = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                            e.Graphics.DrawString(badgeText, badgeFont, brush, badgeRect, format);
                        }
                    }
                }
                e.Handled = true;
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddLine(rect.Left + radius, rect.Top, rect.Right - radius, rect.Top);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddLine(rect.Right - radius, rect.Bottom, rect.Left + radius, rect.Bottom);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.AddLine(rect.Left, rect.Bottom - radius, rect.Left, rect.Top + radius);
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.CloseFigure();
            return path;
        }

        private void dgvWork_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*DataGridViewColumn clickedColumn = dgvWork.Columns[e.ColumnIndex];

            foreach (DataGridViewColumn column in dgvWork.Columns)
            {
                if (column != clickedColumn)
                {
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
            }

            if (clickedColumn.SortMode == DataGridViewColumnSortMode.Programmatic)
            {
                if (clickedColumn.HeaderCell.SortGlyphDirection == SortOrder.Ascending)
                {
                    clickedColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    dgvWork.Sort(clickedColumn, ListSortDirection.Descending);
                }
                else
                {
                    clickedColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    dgvWork.Sort(clickedColumn, ListSortDirection.Ascending);
                }
            }*/
        }

        private void btnRelaxed_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWork.Rows) row.Height = 80;
            dgvWork.RowTemplate.Height = 80;
            btnRelaxed.IconColor = Color.Purple;
            btnRegular.IconColor = Color.FromArgb(160, 160, 160);
            btnCompact.IconColor = Color.FromArgb(160, 160, 160);
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWork.Rows) row.Height = 65;
            dgvWork.RowTemplate.Height = 65;
            btnRegular.IconColor = Color.Purple;
            btnRelaxed.IconColor = Color.FromArgb(160, 160, 160);
            btnCompact.IconColor = Color.FromArgb(160, 160, 160);
        }

        private void btnCompact_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWork.Rows) row.Height = 50;
            dgvWork.RowTemplate.Height = 50;
            btnCompact.IconColor = Color.Purple;
            btnRelaxed.IconColor = Color.FromArgb(160, 160, 160);
            btnRegular.IconColor = Color.FromArgb(160, 160, 160);
        }

        private void dgvWork_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            /*MessageBox.Show("Test");
            BadgeColumn badgeColumn = new BadgeColumn();
            badgeColumn.DataPropertyName = "Törlesztés";
            //badgeColumn.HeaderText = "Header Text";
            badgeColumn.TrueText = "Fizetett";
            badgeColumn.FalseText = "Nem fizetett";
            badgeColumn.TrueBackColor = Color.Green;
            badgeColumn.FalseBackColor = Color.Red;
            badgeColumn.TrueForeColor = Color.White;
            badgeColumn.FalseForeColor = Color.Black;

            foreach (DataGridViewColumn column in dgvWork.Columns)
            {
                if (column.DataPropertyName == badgeColumn.DataPropertyName)
                {
                    column.CellTemplate = badgeColumn.CellTemplate;
                    column.ValueType = typeof(bool);
                    break;
                }
            }*/
        }

        private void dgvWork_SizeChanged(object sender, EventArgs e)
        {
            if (dgvWork.Columns.Count > 0) dgvWork.Columns[0].Width = 30;
        }

        private void tipWork_Draw(object sender, DrawToolTipEventArgs e)
        {
            //const int iconSize = 16;
            //var iconRect = new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, iconSize, iconSize);
            //var icon = SystemIcons.Information;
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
            //e.Graphics.DrawIcon(SystemIcons.Information, iconRect);
        }
    }
}