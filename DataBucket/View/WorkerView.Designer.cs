namespace DataBucket.View
{
    partial class WorkerView
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
            label3 = new Label();
            dgvWorker = new DataGridView();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtQuery = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvWorker).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(6, 6);
            label3.Name = "label3";
            label3.Size = new Size(111, 35);
            label3.TabIndex = 145;
            label3.Text = "Keresés:";
            // 
            // dgvWorker
            // 
            dgvWorker.AllowUserToAddRows = false;
            dgvWorker.AllowUserToDeleteRows = false;
            dgvWorker.AllowUserToResizeRows = false;
            dgvWorker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvWorker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorker.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvWorker.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvWorker.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(165, 98, 170);
            dataGridViewCellStyle1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(139, 70, 159);
            dataGridViewCellStyle1.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvWorker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWorker.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvWorker.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWorker.EnableHeadersVisualStyles = false;
            dgvWorker.GridColor = Color.FromArgb(25, 25, 25);
            dgvWorker.Location = new Point(6, 48);
            dgvWorker.Name = "dgvWorker";
            dgvWorker.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvWorker.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvWorker.RowHeadersVisible = false;
            dgvWorker.RowHeadersWidth = 51;
            dgvWorker.RowTemplate.Height = 65;
            dgvWorker.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvWorker.ScrollBars = ScrollBars.Vertical;
            dgvWorker.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorker.Size = new Size(395, 719);
            dgvWorker.TabIndex = 153;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(40, 40, 40);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnDelete.IconColor = Color.Red;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 36;
            btnDelete.Location = new Point(365, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(36, 36);
            btnDelete.TabIndex = 159;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(40, 40, 40);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEdit.IconColor = Color.Gold;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 36;
            btnEdit.Location = new Point(320, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(36, 36);
            btnEdit.TabIndex = 158;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(40, 40, 40);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAdd.IconColor = Color.DeepSkyBlue;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 36;
            btnAdd.Location = new Point(275, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(36, 36);
            btnAdd.TabIndex = 157;
            btnAdd.UseVisualStyleBackColor = false;
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
            btnRefresh.TabIndex = 156;
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
            btnSearch.TabIndex = 155;
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
            txtQuery.TabIndex = 154;
            // 
            // WorkerView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtQuery);
            Controls.Add(dgvWorker);
            Controls.Add(label3);
            Name = "WorkerView";
            Padding = new Padding(3);
            Size = new Size(1282, 773);
            Load += WorkerView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWorker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private DataGridView dgvWorker;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtQuery;
    }
}
