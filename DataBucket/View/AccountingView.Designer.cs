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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.rdbThisWeek = new System.Windows.Forms.RadioButton();
            this.rdbLastWeek = new System.Windows.Forms.RadioButton();
            this.rdbLastMonth = new System.Windows.Forms.RadioButton();
            this.rdbThisMonth = new System.Windows.Forms.RadioButton();
            this.rdbYesterday = new System.Windows.Forms.RadioButton();
            this.rdbToday = new System.Windows.Forms.RadioButton();
            this.rdbThisYear = new System.Windows.Forms.RadioButton();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rdbLastYear = new System.Windows.Forms.RadioButton();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.pnlDateSelectors = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.dgvMonthly = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pgnMonthly = new DataBucket.UI.Pagination();
            this.pgnDaily = new DataBucket.UI.Pagination();
            this.pgnAll = new DataBucket.UI.Pagination();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.pnlDateSelectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthly)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(263, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 35);
            this.label2.TabIndex = 123;
            this.label2.Text = "Szerelő/Kísérő:";
            // 
            // cmbWorker
            // 
            this.cmbWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWorker.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbWorker.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbWorker.Location = new System.Drawing.Point(456, 6);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(276, 36);
            this.cmbWorker.TabIndex = 122;
            // 
            // rdbThisWeek
            // 
            this.rdbThisWeek.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbThisWeek.AutoSize = true;
            this.rdbThisWeek.FlatAppearance.BorderSize = 0;
            this.rdbThisWeek.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbThisWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbThisWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbThisWeek.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbThisWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdbThisWeek.Location = new System.Drawing.Point(153, 0);
            this.rdbThisWeek.Name = "rdbThisWeek";
            this.rdbThisWeek.Size = new System.Drawing.Size(94, 38);
            this.rdbThisWeek.TabIndex = 124;
            this.rdbThisWeek.Text = "Ez a hét";
            this.rdbThisWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbThisWeek.UseVisualStyleBackColor = true;
            // 
            // rdbLastWeek
            // 
            this.rdbLastWeek.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbLastWeek.AutoSize = true;
            this.rdbLastWeek.FlatAppearance.BorderSize = 0;
            this.rdbLastWeek.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbLastWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbLastWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbLastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLastWeek.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbLastWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdbLastWeek.Location = new System.Drawing.Point(253, 0);
            this.rdbLastWeek.Name = "rdbLastWeek";
            this.rdbLastWeek.Size = new System.Drawing.Size(106, 38);
            this.rdbLastWeek.TabIndex = 125;
            this.rdbLastWeek.Text = "Előző hét";
            this.rdbLastWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbLastWeek.UseVisualStyleBackColor = true;
            // 
            // rdbLastMonth
            // 
            this.rdbLastMonth.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbLastMonth.AutoSize = true;
            this.rdbLastMonth.FlatAppearance.BorderSize = 0;
            this.rdbLastMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbLastMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbLastMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLastMonth.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbLastMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdbLastMonth.Location = new System.Drawing.Point(493, 0);
            this.rdbLastMonth.Name = "rdbLastMonth";
            this.rdbLastMonth.Size = new System.Drawing.Size(134, 38);
            this.rdbLastMonth.TabIndex = 127;
            this.rdbLastMonth.Text = "Előző hónap";
            this.rdbLastMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbLastMonth.UseVisualStyleBackColor = true;
            // 
            // rdbThisMonth
            // 
            this.rdbThisMonth.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbThisMonth.AutoSize = true;
            this.rdbThisMonth.FlatAppearance.BorderSize = 0;
            this.rdbThisMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbThisMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbThisMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbThisMonth.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdbThisMonth.Location = new System.Drawing.Point(365, 0);
            this.rdbThisMonth.Name = "rdbThisMonth";
            this.rdbThisMonth.Size = new System.Drawing.Size(122, 38);
            this.rdbThisMonth.TabIndex = 126;
            this.rdbThisMonth.Text = "Ez a hónap";
            this.rdbThisMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbThisMonth.UseVisualStyleBackColor = true;
            // 
            // rdbYesterday
            // 
            this.rdbYesterday.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbYesterday.AutoSize = true;
            this.rdbYesterday.FlatAppearance.BorderSize = 0;
            this.rdbYesterday.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbYesterday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbYesterday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbYesterday.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbYesterday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdbYesterday.Location = new System.Drawing.Point(59, 0);
            this.rdbYesterday.Name = "rdbYesterday";
            this.rdbYesterday.Size = new System.Drawing.Size(88, 38);
            this.rdbYesterday.TabIndex = 129;
            this.rdbYesterday.Text = "Tegnap";
            this.rdbYesterday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbYesterday.UseVisualStyleBackColor = true;
            // 
            // rdbToday
            // 
            this.rdbToday.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbToday.AutoSize = true;
            this.rdbToday.Checked = true;
            this.rdbToday.FlatAppearance.BorderSize = 0;
            this.rdbToday.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbToday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbToday.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbToday.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdbToday.Location = new System.Drawing.Point(0, 0);
            this.rdbToday.Name = "rdbToday";
            this.rdbToday.Size = new System.Drawing.Size(53, 38);
            this.rdbToday.TabIndex = 128;
            this.rdbToday.TabStop = true;
            this.rdbToday.Text = "Ma";
            this.rdbToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbToday.UseVisualStyleBackColor = true;
            // 
            // rdbThisYear
            // 
            this.rdbThisYear.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbThisYear.AutoSize = true;
            this.rdbThisYear.FlatAppearance.BorderSize = 0;
            this.rdbThisYear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbThisYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbThisYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbThisYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbThisYear.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbThisYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdbThisYear.Location = new System.Drawing.Point(633, 0);
            this.rdbThisYear.Name = "rdbThisYear";
            this.rdbThisYear.Size = new System.Drawing.Size(63, 38);
            this.rdbThisYear.TabIndex = 130;
            this.rdbThisYear.Text = "Idén";
            this.rdbThisYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbThisYear.UseVisualStyleBackColor = true;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBeginDate.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpBeginDate.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtpBeginDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpBeginDate.CustomFormat = "yyyy-MM-dd (dddd)";
            this.dtpBeginDate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginDate.Location = new System.Drawing.Point(738, 6);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(266, 36);
            this.dtpBeginDate.TabIndex = 131;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd (dddd)";
            this.dtpEndDate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(1010, 6);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(266, 36);
            this.dtpEndDate.TabIndex = 132;
            // 
            // rdbLastYear
            // 
            this.rdbLastYear.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbLastYear.AutoSize = true;
            this.rdbLastYear.FlatAppearance.BorderSize = 0;
            this.rdbLastYear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbLastYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbLastYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbLastYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLastYear.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdbLastYear.Location = new System.Drawing.Point(702, 0);
            this.rdbLastYear.Name = "rdbLastYear";
            this.rdbLastYear.Size = new System.Drawing.Size(78, 38);
            this.rdbLastYear.TabIndex = 133;
            this.rdbLastYear.Text = "Tavaly";
            this.rdbLastYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbLastYear.UseVisualStyleBackColor = true;
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.AllowUserToResizeRows = false;
            this.dgvAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(70)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAll.ColumnHeadersHeight = 50;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAll.EnableHeadersVisualStyles = false;
            this.dgvAll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dgvAll.Location = new System.Drawing.Point(653, 123);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAll.RowHeadersVisible = false;
            this.dgvAll.RowHeadersWidth = 51;
            this.dgvAll.RowTemplate.Height = 65;
            this.dgvAll.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAll.Size = new System.Drawing.Size(623, 604);
            this.dgvAll.TabIndex = 134;
            // 
            // rdbAll
            // 
            this.rdbAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAll.AutoSize = true;
            this.rdbAll.FlatAppearance.BorderSize = 0;
            this.rdbAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rdbAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdbAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rdbAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbAll.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdbAll.Location = new System.Drawing.Point(786, 0);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(83, 38);
            this.rdbAll.TabIndex = 135;
            this.rdbAll.Text = "Összes";
            this.rdbAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // pnlDateSelectors
            // 
            this.pnlDateSelectors.Controls.Add(this.rdbToday);
            this.pnlDateSelectors.Controls.Add(this.rdbAll);
            this.pnlDateSelectors.Controls.Add(this.rdbThisWeek);
            this.pnlDateSelectors.Controls.Add(this.rdbLastWeek);
            this.pnlDateSelectors.Controls.Add(this.rdbLastYear);
            this.pnlDateSelectors.Controls.Add(this.rdbThisMonth);
            this.pnlDateSelectors.Controls.Add(this.rdbLastMonth);
            this.pnlDateSelectors.Controls.Add(this.rdbYesterday);
            this.pnlDateSelectors.Controls.Add(this.rdbThisYear);
            this.pnlDateSelectors.Location = new System.Drawing.Point(6, 48);
            this.pnlDateSelectors.Name = "pnlDateSelectors";
            this.pnlDateSelectors.Size = new System.Drawing.Size(889, 38);
            this.pnlDateSelectors.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 35);
            this.label1.TabIndex = 142;
            this.label1.Text = "Keresés:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRefresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(26)))));
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 36;
            this.btnRefresh.Location = new System.Drawing.Point(224, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 36);
            this.btnRefresh.TabIndex = 141;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 32;
            this.btnSearch.Location = new System.Drawing.Point(178, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 140;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuery.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtQuery.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtQuery.Location = new System.Drawing.Point(117, 6);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(95, 36);
            this.txtQuery.TabIndex = 139;
            // 
            // dgvDaily
            // 
            this.dgvDaily.AllowUserToAddRows = false;
            this.dgvDaily.AllowUserToDeleteRows = false;
            this.dgvDaily.AllowUserToResizeRows = false;
            this.dgvDaily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDaily.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvDaily.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDaily.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(70)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDaily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDaily.ColumnHeadersHeight = 50;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDaily.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDaily.EnableHeadersVisualStyles = false;
            this.dgvDaily.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dgvDaily.Location = new System.Drawing.Point(6, 123);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDaily.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDaily.RowHeadersVisible = false;
            this.dgvDaily.RowHeadersWidth = 51;
            this.dgvDaily.RowTemplate.Height = 65;
            this.dgvDaily.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDaily.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaily.Size = new System.Drawing.Size(641, 258);
            this.dgvDaily.TabIndex = 152;
            // 
            // dgvMonthly
            // 
            this.dgvMonthly.AllowUserToAddRows = false;
            this.dgvMonthly.AllowUserToDeleteRows = false;
            this.dgvMonthly.AllowUserToResizeRows = false;
            this.dgvMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthly.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvMonthly.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMonthly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(70)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMonthly.ColumnHeadersHeight = 50;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthly.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMonthly.EnableHeadersVisualStyles = false;
            this.dgvMonthly.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dgvMonthly.Location = new System.Drawing.Point(6, 455);
            this.dgvMonthly.Name = "dgvMonthly";
            this.dgvMonthly.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthly.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMonthly.RowHeadersVisible = false;
            this.dgvMonthly.RowHeadersWidth = 51;
            this.dgvMonthly.RowTemplate.Height = 65;
            this.dgvMonthly.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthly.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMonthly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthly.Size = new System.Drawing.Size(641, 272);
            this.dgvMonthly.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(651, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 157;
            this.label3.Text = "Tételenként";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(4, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 158;
            this.label4.Text = "Naponta";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(4, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 159;
            this.label5.Text = "Havonta";
            // 
            // pgnMonthly
            // 
            this.pgnMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgnMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pgnMonthly.CurrentPage = ((short)(1));
            this.pgnMonthly.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pgnMonthly.ForeColor = System.Drawing.Color.Gainsboro;
            this.pgnMonthly.LastPage = ((short)(1));
            this.pgnMonthly.Location = new System.Drawing.Point(635, 733);
            this.pgnMonthly.Name = "pgnMonthly";
            this.pgnMonthly.PageLimit = ((byte)(3));
            this.pgnMonthly.Size = new System.Drawing.Size(641, 34);
            this.pgnMonthly.TabIndex = 156;
            this.pgnMonthly.TotalRows = ((long)(0));
            // 
            // pgnDaily
            // 
            this.pgnDaily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pgnDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pgnDaily.CurrentPage = ((short)(1));
            this.pgnDaily.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pgnDaily.ForeColor = System.Drawing.Color.Gainsboro;
            this.pgnDaily.LastPage = ((short)(1));
            this.pgnDaily.Location = new System.Drawing.Point(6, 387);
            this.pgnDaily.Name = "pgnDaily";
            this.pgnDaily.PageLimit = ((byte)(10));
            this.pgnDaily.Size = new System.Drawing.Size(641, 34);
            this.pgnDaily.TabIndex = 154;
            this.pgnDaily.TotalRows = ((long)(0));
            // 
            // pgnAll
            // 
            this.pgnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pgnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pgnAll.CurrentPage = ((short)(1));
            this.pgnAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pgnAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.pgnAll.LastPage = ((short)(1));
            this.pgnAll.Location = new System.Drawing.Point(6, 733);
            this.pgnAll.Name = "pgnAll";
            this.pgnAll.PageLimit = ((byte)(15));
            this.pgnAll.Size = new System.Drawing.Size(641, 34);
            this.pgnAll.TabIndex = 153;
            this.pgnAll.TotalRows = ((long)(0));
            // 
            // AccountingView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pgnMonthly);
            this.Controls.Add(this.dgvMonthly);
            this.Controls.Add(this.pgnDaily);
            this.Controls.Add(this.pgnAll);
            this.Controls.Add(this.dgvDaily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.pnlDateSelectors);
            this.Controls.Add(this.dgvAll);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbWorker);
            this.Name = "AccountingView";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1282, 773);
            this.Load += new System.EventHandler(this.AccountingView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.pnlDateSelectors.ResumeLayout(false);
            this.pnlDateSelectors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
