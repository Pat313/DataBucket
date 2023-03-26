namespace DataBucket.View
{
    partial class AccountingView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            label2 = new Label();
            cmbWorker = new ComboBox();
            rdbThisWeek = new RadioButton();
            rdbLastWeek = new RadioButton();
            rdbLastMonth = new RadioButton();
            rdbThisMonth = new RadioButton();
            rdbYesterday = new RadioButton();
            rdbToday = new RadioButton();
            rdbThisYear = new RadioButton();
            dtpBeginDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            rdbLastYear = new RadioButton();
            dgvAll = new DataGridView();
            rdbAll = new RadioButton();
            pnlDateSelectors = new Panel();
            label1 = new Label();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtQuery = new TextBox();
            dgvDaily = new DataGridView();
            dgvMonthly = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pgnMonthly = new UI.Pagination();
            pgnDaily = new UI.Pagination();
            pgnAll = new UI.Pagination();
            ((System.ComponentModel.ISupportInitialize)dgvAll).BeginInit();
            pnlDateSelectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaily).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthly).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(263, 6);
            label2.Name = "label2";
            label2.Size = new Size(187, 35);
            label2.TabIndex = 123;
            label2.Text = "Szerelő/Kísérő:";
            // 
            // cmbWorker
            // 
            cmbWorker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbWorker.BackColor = Color.FromArgb(35, 35, 35);
            cmbWorker.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorker.FlatStyle = FlatStyle.Flat;
            cmbWorker.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbWorker.ForeColor = Color.Gainsboro;
            cmbWorker.Location = new Point(456, 6);
            cmbWorker.Name = "cmbWorker";
            cmbWorker.Size = new Size(276, 36);
            cmbWorker.TabIndex = 122;
            // 
            // rdbThisWeek
            // 
            rdbThisWeek.Appearance = Appearance.Button;
            rdbThisWeek.AutoSize = true;
            rdbThisWeek.FlatAppearance.BorderSize = 0;
            rdbThisWeek.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbThisWeek.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbThisWeek.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbThisWeek.FlatStyle = FlatStyle.Flat;
            rdbThisWeek.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbThisWeek.ForeColor = Color.FromArgb(160, 160, 160);
            rdbThisWeek.Location = new Point(153, 0);
            rdbThisWeek.Name = "rdbThisWeek";
            rdbThisWeek.Size = new Size(94, 38);
            rdbThisWeek.TabIndex = 124;
            rdbThisWeek.Text = "Ez a hét";
            rdbThisWeek.TextAlign = ContentAlignment.MiddleCenter;
            rdbThisWeek.UseVisualStyleBackColor = true;
            // 
            // rdbLastWeek
            // 
            rdbLastWeek.Appearance = Appearance.Button;
            rdbLastWeek.AutoSize = true;
            rdbLastWeek.FlatAppearance.BorderSize = 0;
            rdbLastWeek.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbLastWeek.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbLastWeek.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbLastWeek.FlatStyle = FlatStyle.Flat;
            rdbLastWeek.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbLastWeek.ForeColor = Color.FromArgb(160, 160, 160);
            rdbLastWeek.Location = new Point(253, 0);
            rdbLastWeek.Name = "rdbLastWeek";
            rdbLastWeek.Size = new Size(106, 38);
            rdbLastWeek.TabIndex = 125;
            rdbLastWeek.Text = "Előző hét";
            rdbLastWeek.TextAlign = ContentAlignment.MiddleCenter;
            rdbLastWeek.UseVisualStyleBackColor = true;
            // 
            // rdbLastMonth
            // 
            rdbLastMonth.Appearance = Appearance.Button;
            rdbLastMonth.AutoSize = true;
            rdbLastMonth.FlatAppearance.BorderSize = 0;
            rdbLastMonth.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbLastMonth.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbLastMonth.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbLastMonth.FlatStyle = FlatStyle.Flat;
            rdbLastMonth.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbLastMonth.ForeColor = Color.FromArgb(160, 160, 160);
            rdbLastMonth.Location = new Point(493, 0);
            rdbLastMonth.Name = "rdbLastMonth";
            rdbLastMonth.Size = new Size(134, 38);
            rdbLastMonth.TabIndex = 127;
            rdbLastMonth.Text = "Előző hónap";
            rdbLastMonth.TextAlign = ContentAlignment.MiddleCenter;
            rdbLastMonth.UseVisualStyleBackColor = true;
            // 
            // rdbThisMonth
            // 
            rdbThisMonth.Appearance = Appearance.Button;
            rdbThisMonth.AutoSize = true;
            rdbThisMonth.FlatAppearance.BorderSize = 0;
            rdbThisMonth.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbThisMonth.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbThisMonth.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbThisMonth.FlatStyle = FlatStyle.Flat;
            rdbThisMonth.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbThisMonth.ForeColor = Color.FromArgb(160, 160, 160);
            rdbThisMonth.Location = new Point(365, 0);
            rdbThisMonth.Name = "rdbThisMonth";
            rdbThisMonth.Size = new Size(122, 38);
            rdbThisMonth.TabIndex = 126;
            rdbThisMonth.Text = "Ez a hónap";
            rdbThisMonth.TextAlign = ContentAlignment.MiddleCenter;
            rdbThisMonth.UseVisualStyleBackColor = true;
            // 
            // rdbYesterday
            // 
            rdbYesterday.Appearance = Appearance.Button;
            rdbYesterday.AutoSize = true;
            rdbYesterday.FlatAppearance.BorderSize = 0;
            rdbYesterday.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbYesterday.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbYesterday.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbYesterday.FlatStyle = FlatStyle.Flat;
            rdbYesterday.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbYesterday.ForeColor = Color.FromArgb(160, 160, 160);
            rdbYesterday.Location = new Point(59, 0);
            rdbYesterday.Name = "rdbYesterday";
            rdbYesterday.Size = new Size(88, 38);
            rdbYesterday.TabIndex = 129;
            rdbYesterday.Text = "Tegnap";
            rdbYesterday.TextAlign = ContentAlignment.MiddleCenter;
            rdbYesterday.UseVisualStyleBackColor = true;
            // 
            // rdbToday
            // 
            rdbToday.Appearance = Appearance.Button;
            rdbToday.AutoSize = true;
            rdbToday.Checked = true;
            rdbToday.FlatAppearance.BorderSize = 0;
            rdbToday.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbToday.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbToday.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbToday.FlatStyle = FlatStyle.Flat;
            rdbToday.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbToday.ForeColor = Color.Gainsboro;
            rdbToday.Location = new Point(0, 0);
            rdbToday.Name = "rdbToday";
            rdbToday.Size = new Size(53, 38);
            rdbToday.TabIndex = 128;
            rdbToday.TabStop = true;
            rdbToday.Text = "Ma";
            rdbToday.TextAlign = ContentAlignment.MiddleCenter;
            rdbToday.UseVisualStyleBackColor = true;
            // 
            // rdbThisYear
            // 
            rdbThisYear.Appearance = Appearance.Button;
            rdbThisYear.AutoSize = true;
            rdbThisYear.FlatAppearance.BorderSize = 0;
            rdbThisYear.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbThisYear.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbThisYear.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbThisYear.FlatStyle = FlatStyle.Flat;
            rdbThisYear.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbThisYear.ForeColor = Color.FromArgb(160, 160, 160);
            rdbThisYear.Location = new Point(633, 0);
            rdbThisYear.Name = "rdbThisYear";
            rdbThisYear.Size = new Size(63, 38);
            rdbThisYear.TabIndex = 130;
            rdbThisYear.Text = "Idén";
            rdbThisYear.TextAlign = ContentAlignment.MiddleCenter;
            rdbThisYear.UseVisualStyleBackColor = true;
            // 
            // dtpBeginDate
            // 
            dtpBeginDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpBeginDate.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBeginDate.CalendarForeColor = Color.Gainsboro;
            dtpBeginDate.CalendarMonthBackground = SystemColors.ActiveBorder;
            dtpBeginDate.CustomFormat = "yyyy-MM-dd (dddd)";
            dtpBeginDate.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBeginDate.Format = DateTimePickerFormat.Custom;
            dtpBeginDate.Location = new Point(738, 6);
            dtpBeginDate.Name = "dtpBeginDate";
            dtpBeginDate.Size = new Size(266, 36);
            dtpBeginDate.TabIndex = 131;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpEndDate.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.CalendarForeColor = Color.Gainsboro;
            dtpEndDate.CalendarMonthBackground = SystemColors.ActiveBorder;
            dtpEndDate.CustomFormat = "yyyy-MM-dd (dddd)";
            dtpEndDate.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(1010, 6);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(266, 36);
            dtpEndDate.TabIndex = 132;
            // 
            // rdbLastYear
            // 
            rdbLastYear.Appearance = Appearance.Button;
            rdbLastYear.AutoSize = true;
            rdbLastYear.FlatAppearance.BorderSize = 0;
            rdbLastYear.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbLastYear.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbLastYear.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbLastYear.FlatStyle = FlatStyle.Flat;
            rdbLastYear.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbLastYear.ForeColor = Color.FromArgb(160, 160, 160);
            rdbLastYear.Location = new Point(702, 0);
            rdbLastYear.Name = "rdbLastYear";
            rdbLastYear.Size = new Size(78, 38);
            rdbLastYear.TabIndex = 133;
            rdbLastYear.Text = "Tavaly";
            rdbLastYear.TextAlign = ContentAlignment.MiddleCenter;
            rdbLastYear.UseVisualStyleBackColor = true;
            // 
            // dgvAll
            // 
            dgvAll.AllowUserToAddRows = false;
            dgvAll.AllowUserToDeleteRows = false;
            dgvAll.AllowUserToResizeRows = false;
            dgvAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAll.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvAll.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAll.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(165, 98, 170);
            dataGridViewCellStyle19.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(139, 70, 159);
            dataGridViewCellStyle19.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            dgvAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvAll.ColumnHeadersHeight = 50;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle20.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle20.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dgvAll.DefaultCellStyle = dataGridViewCellStyle20;
            dgvAll.EnableHeadersVisualStyles = false;
            dgvAll.GridColor = Color.FromArgb(25, 25, 25);
            dgvAll.Location = new Point(653, 123);
            dgvAll.Name = "dgvAll";
            dgvAll.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgvAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dgvAll.RowHeadersVisible = false;
            dgvAll.RowHeadersWidth = 51;
            dgvAll.RowTemplate.Height = 65;
            dgvAll.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvAll.ScrollBars = ScrollBars.Vertical;
            dgvAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAll.Size = new Size(623, 604);
            dgvAll.TabIndex = 134;
            // 
            // rdbAll
            // 
            rdbAll.Appearance = Appearance.Button;
            rdbAll.AutoSize = true;
            rdbAll.FlatAppearance.BorderSize = 0;
            rdbAll.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 80, 80);
            rdbAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            rdbAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            rdbAll.FlatStyle = FlatStyle.Flat;
            rdbAll.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbAll.ForeColor = Color.FromArgb(160, 160, 160);
            rdbAll.Location = new Point(786, 0);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(83, 38);
            rdbAll.TabIndex = 135;
            rdbAll.Text = "Összes";
            rdbAll.TextAlign = ContentAlignment.MiddleCenter;
            rdbAll.UseVisualStyleBackColor = true;
            // 
            // pnlDateSelectors
            // 
            pnlDateSelectors.Controls.Add(rdbToday);
            pnlDateSelectors.Controls.Add(rdbAll);
            pnlDateSelectors.Controls.Add(rdbThisWeek);
            pnlDateSelectors.Controls.Add(rdbLastWeek);
            pnlDateSelectors.Controls.Add(rdbLastYear);
            pnlDateSelectors.Controls.Add(rdbThisMonth);
            pnlDateSelectors.Controls.Add(rdbLastMonth);
            pnlDateSelectors.Controls.Add(rdbYesterday);
            pnlDateSelectors.Controls.Add(rdbThisYear);
            pnlDateSelectors.Location = new Point(6, 48);
            pnlDateSelectors.Name = "pnlDateSelectors";
            pnlDateSelectors.Size = new Size(889, 38);
            pnlDateSelectors.TabIndex = 136;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(111, 35);
            label1.TabIndex = 142;
            label1.Text = "Keresés:";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(40, 40, 40);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnRefresh.IconColor = Color.FromArgb(242, 145, 26);
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 36;
            btnRefresh.Location = new Point(224, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(36, 36);
            btnRefresh.TabIndex = 141;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(50, 50, 50);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.DodgerBlue;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 32;
            btnSearch.Location = new Point(178, 8);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 32);
            btnSearch.TabIndex = 140;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtQuery
            // 
            txtQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuery.BackColor = Color.FromArgb(45, 45, 45);
            txtQuery.BorderStyle = BorderStyle.FixedSingle;
            txtQuery.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuery.ForeColor = Color.Gainsboro;
            txtQuery.Location = new Point(117, 6);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(95, 36);
            txtQuery.TabIndex = 139;
            // 
            // dgvDaily
            // 
            dgvDaily.AllowUserToAddRows = false;
            dgvDaily.AllowUserToDeleteRows = false;
            dgvDaily.AllowUserToResizeRows = false;
            dgvDaily.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvDaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDaily.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvDaily.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDaily.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(165, 98, 170);
            dataGridViewCellStyle22.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(139, 70, 159);
            dataGridViewCellStyle22.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            dgvDaily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dgvDaily.ColumnHeadersHeight = 50;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle23.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle23.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dgvDaily.DefaultCellStyle = dataGridViewCellStyle23;
            dgvDaily.EnableHeadersVisualStyles = false;
            dgvDaily.GridColor = Color.FromArgb(25, 25, 25);
            dgvDaily.Location = new Point(6, 123);
            dgvDaily.Name = "dgvDaily";
            dgvDaily.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dgvDaily.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dgvDaily.RowHeadersVisible = false;
            dgvDaily.RowHeadersWidth = 51;
            dgvDaily.RowTemplate.Height = 65;
            dgvDaily.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvDaily.ScrollBars = ScrollBars.Vertical;
            dgvDaily.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDaily.Size = new Size(641, 258);
            dgvDaily.TabIndex = 152;
            // 
            // dgvMonthly
            // 
            dgvMonthly.AllowUserToAddRows = false;
            dgvMonthly.AllowUserToDeleteRows = false;
            dgvMonthly.AllowUserToResizeRows = false;
            dgvMonthly.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgvMonthly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthly.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvMonthly.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMonthly.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(165, 98, 170);
            dataGridViewCellStyle25.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle25.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(139, 70, 159);
            dataGridViewCellStyle25.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.False;
            dgvMonthly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            dgvMonthly.ColumnHeadersHeight = 50;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle26.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle26.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle26.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle26.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            dgvMonthly.DefaultCellStyle = dataGridViewCellStyle26;
            dgvMonthly.EnableHeadersVisualStyles = false;
            dgvMonthly.GridColor = Color.FromArgb(25, 25, 25);
            dgvMonthly.Location = new Point(6, 455);
            dgvMonthly.Name = "dgvMonthly";
            dgvMonthly.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            dgvMonthly.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dgvMonthly.RowHeadersVisible = false;
            dgvMonthly.RowHeadersWidth = 51;
            dgvMonthly.RowTemplate.Height = 65;
            dgvMonthly.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvMonthly.ScrollBars = ScrollBars.Vertical;
            dgvMonthly.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonthly.Size = new Size(641, 272);
            dgvMonthly.TabIndex = 155;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(200, 200, 200);
            label3.Location = new Point(651, 89);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 157;
            label3.Text = "Tételenként";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(200, 200, 200);
            label4.Location = new Point(4, 92);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 158;
            label4.Text = "Naponta";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(200, 200, 200);
            label5.Location = new Point(4, 424);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 159;
            label5.Text = "Havonta";
            // 
            // pgnMonthly
            // 
            pgnMonthly.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pgnMonthly.BackColor = Color.FromArgb(40, 40, 40);
            pgnMonthly.CurrentPage = 1;
            pgnMonthly.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pgnMonthly.ForeColor = Color.Gainsboro;
            pgnMonthly.LastPage = 1;
            pgnMonthly.Location = new Point(6, 733);
            pgnMonthly.Name = "pgnMonthly";
            pgnMonthly.PageLimit = 3;
            pgnMonthly.Size = new Size(641, 34);
            pgnMonthly.TabIndex = 156;
            pgnMonthly.TotalRows = 0L;
            // 
            // pgnDaily
            // 
            pgnDaily.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pgnDaily.BackColor = Color.FromArgb(40, 40, 40);
            pgnDaily.CurrentPage = 1;
            pgnDaily.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pgnDaily.ForeColor = Color.Gainsboro;
            pgnDaily.LastPage = 1;
            pgnDaily.Location = new Point(6, 387);
            pgnDaily.Name = "pgnDaily";
            pgnDaily.PageLimit = 10;
            pgnDaily.Size = new Size(641, 34);
            pgnDaily.TabIndex = 154;
            pgnDaily.TotalRows = 0L;
            // 
            // pgnAll
            // 
            pgnAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pgnAll.BackColor = Color.FromArgb(40, 40, 40);
            pgnAll.CurrentPage = 1;
            pgnAll.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pgnAll.ForeColor = Color.Gainsboro;
            pgnAll.LastPage = 1;
            pgnAll.Location = new Point(653, 733);
            pgnAll.Name = "pgnAll";
            pgnAll.PageLimit = 15;
            pgnAll.Size = new Size(623, 34);
            pgnAll.TabIndex = 153;
            pgnAll.TotalRows = 0L;
            // 
            // AccountingView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pgnMonthly);
            Controls.Add(dgvMonthly);
            Controls.Add(pgnDaily);
            Controls.Add(pgnAll);
            Controls.Add(dgvDaily);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtQuery);
            Controls.Add(pnlDateSelectors);
            Controls.Add(dgvAll);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpBeginDate);
            Controls.Add(label2);
            Controls.Add(cmbWorker);
            Name = "AccountingView";
            Padding = new Padding(3);
            Size = new Size(1282, 773);
            Load += AccountingView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAll).EndInit();
            pnlDateSelectors.ResumeLayout(false);
            pnlDateSelectors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaily).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthly).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.RadioButton rdbThisWeek;
        private System.Windows.Forms.RadioButton rdbLastWeek;
        private System.Windows.Forms.RadioButton rdbLastMonth;
        private System.Windows.Forms.RadioButton rdbThisMonth;
        private System.Windows.Forms.RadioButton rdbYesterday;
        private System.Windows.Forms.RadioButton rdbToday;
        private System.Windows.Forms.RadioButton rdbThisYear;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.RadioButton rdbLastYear;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.Panel pnlDateSelectors;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.DataGridView dgvDaily;
        private UI.Pagination pgnAll;
        private UI.Pagination pgnDaily;
        private System.Windows.Forms.DataGridView dgvMonthly;
        private UI.Pagination pgnMonthly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
