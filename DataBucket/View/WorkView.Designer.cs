namespace DataBucket.View
{
    partial class WorkView
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label13 = new Label();
            cmbRepairman = new ComboBox();
            flpImages = new FlowLayoutPanel();
            txtQuery = new TextBox();
            dgvWork = new DataGridView();
            cmsWork = new ContextMenuStrip(components);
            cmsItemAdd = new FontAwesome.Sharp.IconMenuItem();
            cmsItemEdit = new FontAwesome.Sharp.IconMenuItem();
            cmsItemDelete = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cmsItemRefresh = new FontAwesome.Sharp.IconMenuItem();
            cmsItemImages = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            cmsItemGridalign = new FontAwesome.Sharp.IconMenuItem();
            cmsGridalign = new ContextMenuStrip(components);
            cmsItemRelaxed = new FontAwesome.Sharp.IconMenuItem();
            cmsItemRegular = new FontAwesome.Sharp.IconMenuItem();
            cmsItemCompact = new FontAwesome.Sharp.IconMenuItem();
            cmbConcomitant = new ComboBox();
            tipWork = new ToolTip(components);
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnRelaxed = new FontAwesome.Sharp.IconButton();
            btnCompact = new FontAwesome.Sharp.IconButton();
            btnRegular = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnImages = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            pgnWork = new UI.Pagination();
            txtExtraInfo = new TextBoxEx();
            cldWork = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)dgvWork).BeginInit();
            cmsWork.SuspendLayout();
            cmsGridalign.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Gainsboro;
            label13.Location = new Point(405, 6);
            label13.Name = "label13";
            label13.Size = new Size(127, 35);
            label13.TabIndex = 121;
            label13.Text = "Dolgozók:";
            // 
            // cmbRepairman
            // 
            cmbRepairman.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbRepairman.BackColor = Color.FromArgb(40, 40, 40);
            cmbRepairman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepairman.FlatStyle = FlatStyle.Flat;
            cmbRepairman.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRepairman.ForeColor = Color.Gainsboro;
            cmbRepairman.Location = new Point(538, 6);
            cmbRepairman.Name = "cmbRepairman";
            cmbRepairman.Size = new Size(211, 36);
            cmbRepairman.TabIndex = 120;
            // 
            // flpImages
            // 
            flpImages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flpImages.AutoScroll = true;
            flpImages.BackColor = Color.FromArgb(45, 45, 45);
            flpImages.BorderStyle = BorderStyle.FixedSingle;
            flpImages.Location = new Point(916, 371);
            flpImages.Name = "flpImages";
            flpImages.Size = new Size(360, 396);
            flpImages.TabIndex = 118;
            // 
            // txtQuery
            // 
            txtQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuery.BackColor = Color.FromArgb(50, 50, 50);
            txtQuery.BorderStyle = BorderStyle.FixedSingle;
            txtQuery.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuery.ForeColor = Color.Gainsboro;
            txtQuery.Location = new Point(117, 6);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(95, 36);
            txtQuery.TabIndex = 116;
            tipWork.SetToolTip(txtQuery, "Keresés ügyfelek címei és nevei között");
            // 
            // dgvWork
            // 
            dgvWork.AllowUserToAddRows = false;
            dgvWork.AllowUserToDeleteRows = false;
            dgvWork.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dgvWork.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvWork.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvWork.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWork.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvWork.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvWork.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(139, 70, 159);
            dataGridViewCellStyle2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(139, 70, 159);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvWork.ColumnHeadersHeight = 50;
            dgvWork.ContextMenuStrip = cmsWork;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(180, 180, 180);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvWork.DefaultCellStyle = dataGridViewCellStyle3;
            dgvWork.EnableHeadersVisualStyles = false;
            dgvWork.GridColor = Color.FromArgb(25, 25, 25);
            dgvWork.Location = new Point(6, 49);
            dgvWork.Name = "dgvWork";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvWork.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvWork.RowHeadersVisible = false;
            dgvWork.RowHeadersWidth = 51;
            dgvWork.RowTemplate.Height = 65;
            dgvWork.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvWork.ScrollBars = ScrollBars.Vertical;
            dgvWork.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWork.Size = new Size(904, 678);
            dgvWork.TabIndex = 111;
            // 
            // cmsWork
            // 
            cmsWork.BackColor = Color.FromArgb(45, 45, 45);
            cmsWork.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmsWork.ImageScalingSize = new Size(20, 20);
            cmsWork.Items.AddRange(new ToolStripItem[] { cmsItemAdd, cmsItemEdit, cmsItemDelete, toolStripSeparator1, cmsItemRefresh, cmsItemImages, toolStripSeparator2, cmsItemGridalign });
            cmsWork.Name = "cmsWork";
            cmsWork.RenderMode = ToolStripRenderMode.System;
            cmsWork.Size = new Size(229, 232);
            // 
            // cmsItemAdd
            // 
            cmsItemAdd.ForeColor = Color.Gainsboro;
            cmsItemAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            cmsItemAdd.IconColor = Color.DeepSkyBlue;
            cmsItemAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemAdd.IconSize = 30;
            cmsItemAdd.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemAdd.Name = "cmsItemAdd";
            cmsItemAdd.Size = new Size(228, 36);
            cmsItemAdd.Text = "Hozzáadás";
            // 
            // cmsItemEdit
            // 
            cmsItemEdit.ForeColor = Color.Gainsboro;
            cmsItemEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            cmsItemEdit.IconColor = Color.Gold;
            cmsItemEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemEdit.IconSize = 30;
            cmsItemEdit.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemEdit.Name = "cmsItemEdit";
            cmsItemEdit.Size = new Size(228, 36);
            cmsItemEdit.Text = "Szerkesztés";
            // 
            // cmsItemDelete
            // 
            cmsItemDelete.ForeColor = Color.Gainsboro;
            cmsItemDelete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            cmsItemDelete.IconColor = Color.Red;
            cmsItemDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemDelete.IconSize = 30;
            cmsItemDelete.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemDelete.Name = "cmsItemDelete";
            cmsItemDelete.Size = new Size(228, 36);
            cmsItemDelete.Text = "Törlés";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.FromArgb(120, 120, 120);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(225, 6);
            // 
            // cmsItemRefresh
            // 
            cmsItemRefresh.ForeColor = Color.Gainsboro;
            cmsItemRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            cmsItemRefresh.IconColor = Color.FromArgb(242, 145, 26);
            cmsItemRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemRefresh.IconSize = 30;
            cmsItemRefresh.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemRefresh.Name = "cmsItemRefresh";
            cmsItemRefresh.Size = new Size(228, 36);
            cmsItemRefresh.Text = "Frissítés";
            // 
            // cmsItemImages
            // 
            cmsItemImages.ForeColor = Color.Gainsboro;
            cmsItemImages.IconChar = FontAwesome.Sharp.IconChar.Panorama;
            cmsItemImages.IconColor = Color.FromArgb(76, 221, 104);
            cmsItemImages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemImages.IconSize = 30;
            cmsItemImages.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemImages.Name = "cmsItemImages";
            cmsItemImages.Size = new Size(228, 36);
            cmsItemImages.Text = "Képek betöltése";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = Color.FromArgb(120, 120, 120);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(225, 6);
            // 
            // cmsItemGridalign
            // 
            cmsItemGridalign.DropDown = cmsGridalign;
            cmsItemGridalign.ForeColor = Color.Gainsboro;
            cmsItemGridalign.IconChar = FontAwesome.Sharp.IconChar.None;
            cmsItemGridalign.IconColor = Color.Purple;
            cmsItemGridalign.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemGridalign.IconSize = 30;
            cmsItemGridalign.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemGridalign.Name = "cmsItemGridalign";
            cmsItemGridalign.ShortcutKeyDisplayString = "";
            cmsItemGridalign.Size = new Size(228, 36);
            cmsItemGridalign.Text = "Elrendezés";
            // 
            // cmsGridalign
            // 
            cmsGridalign.BackColor = Color.FromArgb(45, 45, 45);
            cmsGridalign.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmsGridalign.ImageScalingSize = new Size(20, 20);
            cmsGridalign.Items.AddRange(new ToolStripItem[] { cmsItemRelaxed, cmsItemRegular, cmsItemCompact });
            cmsGridalign.Name = "cmsWork";
            cmsGridalign.OwnerItem = cmsItemGridalign;
            cmsGridalign.RenderMode = ToolStripRenderMode.System;
            cmsGridalign.ShowCheckMargin = true;
            cmsGridalign.Size = new Size(310, 112);
            // 
            // cmsItemRelaxed
            // 
            cmsItemRelaxed.BackColor = Color.FromArgb(45, 45, 45);
            cmsItemRelaxed.ForeColor = Color.Gainsboro;
            cmsItemRelaxed.IconChar = FontAwesome.Sharp.IconChar.Table;
            cmsItemRelaxed.IconColor = Color.Purple;
            cmsItemRelaxed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemRelaxed.IconSize = 30;
            cmsItemRelaxed.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemRelaxed.Name = "cmsItemRelaxed";
            cmsItemRelaxed.Size = new Size(309, 36);
            cmsItemRelaxed.Text = "Nyugodt (laza)";
            // 
            // cmsItemRegular
            // 
            cmsItemRegular.BackColor = Color.FromArgb(45, 45, 45);
            cmsItemRegular.Checked = true;
            cmsItemRegular.CheckState = CheckState.Checked;
            cmsItemRegular.ForeColor = Color.Gainsboro;
            cmsItemRegular.IconChar = FontAwesome.Sharp.IconChar.List;
            cmsItemRegular.IconColor = Color.Purple;
            cmsItemRegular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemRegular.IconSize = 30;
            cmsItemRegular.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemRegular.Name = "cmsItemRegular";
            cmsItemRegular.Size = new Size(309, 36);
            cmsItemRegular.Text = "Hagyományos (normál)";
            // 
            // cmsItemCompact
            // 
            cmsItemCompact.BackColor = Color.FromArgb(45, 45, 45);
            cmsItemCompact.ForeColor = Color.Gainsboro;
            cmsItemCompact.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            cmsItemCompact.IconColor = Color.Purple;
            cmsItemCompact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cmsItemCompact.IconSize = 30;
            cmsItemCompact.ImageScaling = ToolStripItemImageScaling.None;
            cmsItemCompact.Name = "cmsItemCompact";
            cmsItemCompact.Size = new Size(309, 36);
            cmsItemCompact.Text = "Kompakt (sűrű)";
            // 
            // cmbConcomitant
            // 
            cmbConcomitant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbConcomitant.BackColor = Color.FromArgb(40, 40, 40);
            cmbConcomitant.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConcomitant.FlatStyle = FlatStyle.Flat;
            cmbConcomitant.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbConcomitant.ForeColor = Color.Gainsboro;
            cmbConcomitant.Location = new Point(755, 6);
            cmbConcomitant.Name = "cmbConcomitant";
            cmbConcomitant.Size = new Size(211, 36);
            cmbConcomitant.TabIndex = 129;
            // 
            // tipWork
            // 
            tipWork.BackColor = Color.FromArgb(70, 70, 70);
            tipWork.ForeColor = Color.FromArgb(240, 240, 240);
            tipWork.OwnerDraw = true;
            tipWork.ToolTipTitle = "Segítség";
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
            btnDelete.Location = new Point(359, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(36, 36);
            btnDelete.TabIndex = 141;
            tipWork.SetToolTip(btnDelete, "A kiválasztott sor törlése");
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
            btnEdit.Location = new Point(314, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(36, 36);
            btnEdit.TabIndex = 140;
            tipWork.SetToolTip(btnEdit, "A kiválasztott sor szerkesztése");
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
            btnAdd.Location = new Point(269, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(36, 36);
            btnAdd.TabIndex = 139;
            tipWork.SetToolTip(btnAdd, "Új munka hozzáadása a listához");
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRelaxed
            // 
            btnRelaxed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRelaxed.BackColor = Color.FromArgb(40, 40, 40);
            btnRelaxed.FlatAppearance.BorderSize = 0;
            btnRelaxed.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnRelaxed.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnRelaxed.FlatStyle = FlatStyle.Flat;
            btnRelaxed.IconChar = FontAwesome.Sharp.IconChar.Table;
            btnRelaxed.IconColor = Color.FromArgb(160, 160, 160);
            btnRelaxed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRelaxed.IconSize = 40;
            btnRelaxed.Location = new Point(921, 49);
            btnRelaxed.Name = "btnRelaxed";
            btnRelaxed.Size = new Size(40, 40);
            btnRelaxed.TabIndex = 135;
            tipWork.SetToolTip(btnRelaxed, "Laza elrendezés");
            btnRelaxed.UseVisualStyleBackColor = false;
            // 
            // btnCompact
            // 
            btnCompact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCompact.BackColor = Color.FromArgb(40, 40, 40);
            btnCompact.FlatAppearance.BorderSize = 0;
            btnCompact.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnCompact.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnCompact.FlatStyle = FlatStyle.Flat;
            btnCompact.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnCompact.IconColor = Color.FromArgb(160, 160, 160);
            btnCompact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCompact.IconSize = 40;
            btnCompact.Location = new Point(921, 141);
            btnCompact.Name = "btnCompact";
            btnCompact.Size = new Size(40, 40);
            btnCompact.TabIndex = 134;
            tipWork.SetToolTip(btnCompact, "Sűrű elrendezés");
            btnCompact.UseVisualStyleBackColor = false;
            // 
            // btnRegular
            // 
            btnRegular.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegular.BackColor = Color.FromArgb(40, 40, 40);
            btnRegular.FlatAppearance.BorderSize = 0;
            btnRegular.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnRegular.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnRegular.FlatStyle = FlatStyle.Flat;
            btnRegular.IconChar = FontAwesome.Sharp.IconChar.List;
            btnRegular.IconColor = Color.Purple;
            btnRegular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegular.IconSize = 40;
            btnRegular.Location = new Point(921, 95);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(40, 40);
            btnRegular.TabIndex = 133;
            tipWork.SetToolTip(btnRegular, "Normál elrendezés");
            btnRegular.UseVisualStyleBackColor = false;
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
            btnRefresh.TabIndex = 132;
            tipWork.SetToolTip(btnRefresh, "Újra betölti az adatokat, frissíti a listát");
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnImages
            // 
            btnImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImages.BackColor = Color.FromArgb(40, 40, 40);
            btnImages.FlatAppearance.BorderSize = 0;
            btnImages.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnImages.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnImages.FlatStyle = FlatStyle.Flat;
            btnImages.IconChar = FontAwesome.Sharp.IconChar.Panorama;
            btnImages.IconColor = Color.FromArgb(76, 221, 104);
            btnImages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImages.IconSize = 50;
            btnImages.Location = new Point(916, 187);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(50, 50);
            btnImages.TabIndex = 131;
            tipWork.SetToolTip(btnImages, "Kapcsolódó Signal képek megjelenítése");
            btnImages.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(910, 333);
            label2.Name = "label2";
            label2.Size = new Size(192, 35);
            label2.TabIndex = 137;
            label2.Text = "-> Signal képek:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(6, 6);
            label3.Name = "label3";
            label3.Size = new Size(111, 35);
            label3.TabIndex = 138;
            label3.Text = "Keresés:";
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
            btnSearch.TabIndex = 128;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pgnWork
            // 
            pgnWork.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pgnWork.BackColor = Color.FromArgb(40, 40, 40);
            pgnWork.CurrentPage = 1;
            pgnWork.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pgnWork.ForeColor = Color.Gainsboro;
            pgnWork.LastPage = 1;
            pgnWork.Location = new Point(6, 733);
            pgnWork.Name = "pgnWork";
            pgnWork.PageLimit = 15;
            pgnWork.Size = new Size(904, 34);
            pgnWork.TabIndex = 142;
            pgnWork.TotalRows = 0L;
            // 
            // txtExtraInfo
            // 
            txtExtraInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtExtraInfo.BackColor = Color.FromArgb(40, 40, 40);
            txtExtraInfo.BorderColor = Color.FromArgb(100, 100, 100);
            txtExtraInfo.Location = new Point(916, 238);
            txtExtraInfo.Multiline = true;
            txtExtraInfo.Name = "txtExtraInfo";
            txtExtraInfo.Size = new Size(359, 92);
            txtExtraInfo.TabIndex = 143;
            // 
            // cldWork
            // 
            cldWork.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cldWork.Location = new Point(1029, 6);
            cldWork.MaxSelectionCount = 42;
            cldWork.Name = "cldWork";
            cldWork.ShowWeekNumbers = true;
            cldWork.TabIndex = 144;
            // 
            // WorkView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(cldWork);
            Controls.Add(txtExtraInfo);
            Controls.Add(pgnWork);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRelaxed);
            Controls.Add(btnCompact);
            Controls.Add(btnRegular);
            Controls.Add(btnRefresh);
            Controls.Add(btnImages);
            Controls.Add(cmbConcomitant);
            Controls.Add(btnSearch);
            Controls.Add(label13);
            Controls.Add(txtQuery);
            Controls.Add(flpImages);
            Controls.Add(cmbRepairman);
            Controls.Add(dgvWork);
            Name = "WorkView";
            Padding = new Padding(3);
            Size = new Size(1282, 773);
            Load += WorkView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWork).EndInit();
            cmsWork.ResumeLayout(false);
            cmsGridalign.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbRepairman;
        private System.Windows.Forms.FlowLayoutPanel flpImages;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.DataGridView dgvWork;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.ComboBox cmbConcomitant;
        private FontAwesome.Sharp.IconButton btnImages;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnRegular;
        private FontAwesome.Sharp.IconButton btnCompact;
        private FontAwesome.Sharp.IconButton btnRelaxed;
        private System.Windows.Forms.ContextMenuStrip cmsWork;
        private FontAwesome.Sharp.IconMenuItem cmsItemAdd;
        private FontAwesome.Sharp.IconMenuItem cmsItemEdit;
        private FontAwesome.Sharp.IconMenuItem cmsItemDelete;
        private System.Windows.Forms.ToolTip tipWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem cmsItemRefresh;
        private FontAwesome.Sharp.IconMenuItem cmsItemImages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private FontAwesome.Sharp.IconMenuItem cmsItemGridalign;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.ContextMenuStrip cmsGridalign;
        private FontAwesome.Sharp.IconMenuItem cmsItemRelaxed;
        private FontAwesome.Sharp.IconMenuItem cmsItemRegular;
        private FontAwesome.Sharp.IconMenuItem cmsItemCompact;
        private UI.Pagination pgnWork;
        private TextBoxEx txtExtraInfo;
        private MonthCalendar cldWork;
    }
}
