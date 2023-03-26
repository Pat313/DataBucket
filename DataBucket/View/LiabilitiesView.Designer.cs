namespace DataBucket.View
{
    partial class LiabilitiesView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvLiabilities = new DataGridView();
            dtpEndDate = new DateTimePicker();
            dtpBeginDate = new DateTimePicker();
            label3 = new Label();
            chbShowAll = new CheckBox();
            pgnLiabilities = new UI.Pagination();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtQuery = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLiabilities).BeginInit();
            SuspendLayout();
            // 
            // dgvLiabilities
            // 
            dgvLiabilities.AllowUserToAddRows = false;
            dgvLiabilities.AllowUserToDeleteRows = false;
            dgvLiabilities.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLiabilities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLiabilities.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvLiabilities.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLiabilities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(165, 98, 170);
            dataGridViewCellStyle1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(139, 70, 159);
            dataGridViewCellStyle1.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvLiabilities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLiabilities.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLiabilities.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLiabilities.EnableHeadersVisualStyles = false;
            dgvLiabilities.GridColor = Color.FromArgb(25, 25, 25);
            dgvLiabilities.Location = new Point(6, 48);
            dgvLiabilities.MultiSelect = false;
            dgvLiabilities.Name = "dgvLiabilities";
            dgvLiabilities.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLiabilities.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLiabilities.RowHeadersVisible = false;
            dgvLiabilities.RowHeadersWidth = 51;
            dgvLiabilities.RowTemplate.Height = 65;
            dgvLiabilities.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvLiabilities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLiabilities.Size = new Size(935, 671);
            dgvLiabilities.TabIndex = 114;
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
            dtpEndDate.TabIndex = 134;
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
            dtpBeginDate.TabIndex = 133;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(6, 6);
            label3.Name = "label3";
            label3.Size = new Size(111, 35);
            label3.TabIndex = 149;
            label3.Text = "Keresés:";
            // 
            // chbShowAll
            // 
            chbShowAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chbShowAll.Appearance = Appearance.Button;
            chbShowAll.AutoSize = true;
            chbShowAll.BackColor = Color.FromArgb(60, 30, 30);
            chbShowAll.CheckAlign = ContentAlignment.BottomCenter;
            chbShowAll.Checked = true;
            chbShowAll.CheckState = CheckState.Checked;
            chbShowAll.FlatAppearance.BorderColor = Color.Gainsboro;
            chbShowAll.FlatAppearance.CheckedBackColor = Color.FromArgb(30, 60, 30);
            chbShowAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
            chbShowAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            chbShowAll.FlatStyle = FlatStyle.Flat;
            chbShowAll.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            chbShowAll.ForeColor = Color.Gainsboro;
            chbShowAll.Image = Properties.Resources.checkmark3;
            chbShowAll.Location = new Point(272, 4);
            chbShowAll.Name = "chbShowAll";
            chbShowAll.Size = new Size(196, 38);
            chbShowAll.TabIndex = 150;
            chbShowAll.Text = "Összes mutatása";
            chbShowAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            chbShowAll.UseVisualStyleBackColor = false;
            // 
            // pgnLiabilities
            // 
            pgnLiabilities.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pgnLiabilities.BackColor = Color.FromArgb(40, 40, 40);
            pgnLiabilities.CurrentPage = 1;
            pgnLiabilities.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pgnLiabilities.ForeColor = Color.Gainsboro;
            pgnLiabilities.LastPage = 1;
            pgnLiabilities.Location = new Point(6, 725);
            pgnLiabilities.Name = "pgnLiabilities";
            pgnLiabilities.PageLimit = 15;
            pgnLiabilities.Size = new Size(935, 42);
            pgnLiabilities.TabIndex = 151;
            pgnLiabilities.TotalRows = 0L;
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
            btnRefresh.Location = new Point(230, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(36, 36);
            btnRefresh.TabIndex = 159;
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
            btnSearch.Location = new Point(184, 8);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 32);
            btnSearch.TabIndex = 158;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtQuery
            // 
            txtQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuery.BackColor = Color.FromArgb(50, 50, 50);
            txtQuery.BorderStyle = BorderStyle.FixedSingle;
            txtQuery.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuery.ForeColor = Color.Gainsboro;
            txtQuery.Location = new Point(123, 6);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(95, 36);
            txtQuery.TabIndex = 157;
            // 
            // LiabilitiesView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtQuery);
            Controls.Add(pgnLiabilities);
            Controls.Add(chbShowAll);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpBeginDate);
            Controls.Add(dgvLiabilities);
            Name = "LiabilitiesView";
            Padding = new Padding(3);
            Size = new Size(1282, 773);
            Load += LiabilitiesView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLiabilities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLiabilities;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpBeginDate;
        private Label label3;
        private CheckBox chbShowAll;
        private UI.Pagination pgnLiabilities;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtQuery;
    }
}
