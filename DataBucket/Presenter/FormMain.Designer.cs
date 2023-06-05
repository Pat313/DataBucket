namespace DataBucket.Presenter
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            lblLogo1 = new Label();
            pbLogo = new PictureBox();
            pnlLogo = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            lblLogo2 = new Label();
            pnlMenu = new Panel();
            lblVersion = new Label();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnStatistics = new FontAwesome.Sharp.IconButton();
            btnLiabilities = new FontAwesome.Sharp.IconButton();
            btnAccounting = new FontAwesome.Sharp.IconButton();
            btnWorkers = new FontAwesome.Sharp.IconButton();
            btnWorks = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            pnlTitle = new Panel();
            iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            btnStartServer = new Button();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            lblCurrentChild = new Label();
            pnlMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlLogo.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChild).BeginInit();
            SuspendLayout();
            // 
            // lblLogo1
            // 
            lblLogo1.AutoSize = true;
            lblLogo1.Font = new Font("Forte", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo1.ForeColor = Color.Gainsboro;
            lblLogo1.Location = new Point(92, 23);
            lblLogo1.Name = "lblLogo1";
            lblLogo1.Size = new Size(87, 36);
            lblLogo1.TabIndex = 17;
            lblLogo1.Text = "Adat";
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(23, 23);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(70, 70);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 10;
            pbLogo.TabStop = false;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(btnMenu);
            pnlLogo.Controls.Add(pbLogo);
            pnlLogo.Controls.Add(lblLogo1);
            pnlLogo.Controls.Add(lblLogo2);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Padding = new Padding(20);
            pnlLogo.Size = new Size(300, 120);
            pnlLogo.TabIndex = 16;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMenu.BackColor = Color.FromArgb(30, 30, 30);
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            btnMenu.IconColor = Color.Gainsboro;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 60;
            btnMenu.Location = new Point(220, 30);
            btnMenu.Margin = new Padding(0, 10, 0, 10);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(60, 60);
            btnMenu.TabIndex = 26;
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // lblLogo2
            // 
            lblLogo2.AutoSize = true;
            lblLogo2.Font = new Font("Forte", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo2.ForeColor = Color.DodgerBlue;
            lblLogo2.Location = new Point(93, 62);
            lblLogo2.Name = "lblLogo2";
            lblLogo2.Size = new Size(84, 31);
            lblLogo2.TabIndex = 18;
            lblLogo2.Text = "Vödör";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(30, 30, 30);
            pnlMenu.Controls.Add(lblVersion);
            pnlMenu.Controls.Add(btnSettings);
            pnlMenu.Controls.Add(btnStatistics);
            pnlMenu.Controls.Add(btnLiabilities);
            pnlMenu.Controls.Add(btnAccounting);
            pnlMenu.Controls.Add(btnWorkers);
            pnlMenu.Controls.Add(btnWorks);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(300, 853);
            pnlMenu.TabIndex = 15;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.Location = new Point(12, 816);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(120, 28);
            lblVersion.TabIndex = 24;
            lblVersion.Text = "Ver: 0.0.0.0";
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            btnSettings.IconColor = Color.Gainsboro;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 40;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 600);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 20, 0);
            btnSettings.Size = new Size(300, 80);
            btnSettings.TabIndex = 22;
            btnSettings.Text = "Beállítások";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            btnStatistics.Dock = DockStyle.Top;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnStatistics.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnStatistics.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnStatistics.IconColor = Color.Gainsboro;
            btnStatistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStatistics.IconSize = 40;
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(0, 520);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Padding = new Padding(10, 0, 20, 0);
            btnStatistics.Size = new Size(300, 80);
            btnStatistics.TabIndex = 21;
            btnStatistics.Text = "Statisztika";
            btnStatistics.TextAlign = ContentAlignment.MiddleLeft;
            btnStatistics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnLiabilities
            // 
            btnLiabilities.Dock = DockStyle.Top;
            btnLiabilities.FlatAppearance.BorderSize = 0;
            btnLiabilities.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnLiabilities.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnLiabilities.FlatStyle = FlatStyle.Flat;
            btnLiabilities.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLiabilities.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnLiabilities.IconColor = Color.Gainsboro;
            btnLiabilities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLiabilities.IconSize = 40;
            btnLiabilities.ImageAlign = ContentAlignment.MiddleLeft;
            btnLiabilities.Location = new Point(0, 440);
            btnLiabilities.Name = "btnLiabilities";
            btnLiabilities.Padding = new Padding(10, 0, 20, 0);
            btnLiabilities.Size = new Size(300, 80);
            btnLiabilities.TabIndex = 20;
            btnLiabilities.Text = "Követelések";
            btnLiabilities.TextAlign = ContentAlignment.MiddleLeft;
            btnLiabilities.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLiabilities.UseVisualStyleBackColor = true;
            // 
            // btnAccounting
            // 
            btnAccounting.Dock = DockStyle.Top;
            btnAccounting.FlatAppearance.BorderSize = 0;
            btnAccounting.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnAccounting.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnAccounting.FlatStyle = FlatStyle.Flat;
            btnAccounting.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccounting.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btnAccounting.IconColor = Color.Gainsboro;
            btnAccounting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccounting.IconSize = 40;
            btnAccounting.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccounting.Location = new Point(0, 360);
            btnAccounting.Name = "btnAccounting";
            btnAccounting.Padding = new Padding(10, 0, 20, 0);
            btnAccounting.Size = new Size(300, 80);
            btnAccounting.TabIndex = 19;
            btnAccounting.Text = "Elszámolás";
            btnAccounting.TextAlign = ContentAlignment.MiddleLeft;
            btnAccounting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccounting.UseVisualStyleBackColor = true;
            // 
            // btnWorkers
            // 
            btnWorkers.Dock = DockStyle.Top;
            btnWorkers.FlatAppearance.BorderSize = 0;
            btnWorkers.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnWorkers.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnWorkers.FlatStyle = FlatStyle.Flat;
            btnWorkers.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkers.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnWorkers.IconColor = Color.Gainsboro;
            btnWorkers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWorkers.IconSize = 40;
            btnWorkers.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorkers.Location = new Point(0, 280);
            btnWorkers.Name = "btnWorkers";
            btnWorkers.Padding = new Padding(10, 0, 20, 0);
            btnWorkers.Size = new Size(300, 80);
            btnWorkers.TabIndex = 18;
            btnWorkers.Text = "Munkavállalók";
            btnWorkers.TextAlign = ContentAlignment.MiddleLeft;
            btnWorkers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWorkers.UseVisualStyleBackColor = true;
            // 
            // btnWorks
            // 
            btnWorks.Dock = DockStyle.Top;
            btnWorks.FlatAppearance.BorderSize = 0;
            btnWorks.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnWorks.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnWorks.FlatStyle = FlatStyle.Flat;
            btnWorks.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorks.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            btnWorks.IconColor = Color.Gainsboro;
            btnWorks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWorks.IconSize = 40;
            btnWorks.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorks.Location = new Point(0, 200);
            btnWorks.Name = "btnWorks";
            btnWorks.Padding = new Padding(10, 0, 20, 0);
            btnWorks.Size = new Size(300, 80);
            btnWorks.TabIndex = 17;
            btnWorks.Text = "Munkák";
            btnWorks.TextAlign = ContentAlignment.MiddleLeft;
            btnWorks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWorks.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.Gainsboro;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 40;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 120);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 20, 0);
            btnHome.Size = new Size(300, 80);
            btnHome.TabIndex = 23;
            btnHome.Text = "Kezdőlap";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(35, 35, 35);
            pnlTitle.Controls.Add(iconCurrentChild);
            pnlTitle.Controls.Add(btnStartServer);
            pnlTitle.Controls.Add(btnExit);
            pnlTitle.Controls.Add(btnMaximize);
            pnlTitle.Controls.Add(btnMinimize);
            pnlTitle.Controls.Add(lblCurrentChild);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(300, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1282, 80);
            pnlTitle.TabIndex = 16;
            // 
            // iconCurrentChild
            // 
            iconCurrentChild.BackColor = Color.FromArgb(35, 35, 35);
            iconCurrentChild.ForeColor = Color.Gainsboro;
            iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChild.IconColor = Color.Gainsboro;
            iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconCurrentChild.IconSize = 50;
            iconCurrentChild.Location = new Point(18, 15);
            iconCurrentChild.Margin = new Padding(15, 15, 3, 15);
            iconCurrentChild.Name = "iconCurrentChild";
            iconCurrentChild.Size = new Size(50, 50);
            iconCurrentChild.TabIndex = 21;
            iconCurrentChild.TabStop = false;
            iconCurrentChild.UseGdi = true;
            // 
            // btnStartServer
            // 
            btnStartServer.BackColor = Color.DodgerBlue;
            btnStartServer.FlatAppearance.BorderSize = 0;
            btnStartServer.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 104, 195);
            btnStartServer.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 124, 225);
            btnStartServer.FlatStyle = FlatStyle.Flat;
            btnStartServer.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartServer.ForeColor = Color.Gainsboro;
            btnStartServer.Location = new Point(298, 15);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(269, 50);
            btnStartServer.TabIndex = 125;
            btnStartServer.Text = "Szerver indítása";
            btnStartServer.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 55);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 25;
            btnExit.Location = new Point(1237, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 30);
            btnExit.TabIndex = 27;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 55);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.Gainsboro;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 25;
            btnMaximize.Location = new Point(1192, 0);
            btnMaximize.Margin = new Padding(0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(45, 30);
            btnMaximize.TabIndex = 26;
            btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 55);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Gainsboro;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 25;
            btnMinimize.Location = new Point(1147, 0);
            btnMinimize.Margin = new Padding(0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 30);
            btnMinimize.TabIndex = 25;
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // lblCurrentChild
            // 
            lblCurrentChild.AutoSize = true;
            lblCurrentChild.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentChild.Location = new Point(74, 28);
            lblCurrentChild.Name = "lblCurrentChild";
            lblCurrentChild.Size = new Size(127, 37);
            lblCurrentChild.TabIndex = 21;
            lblCurrentChild.Text = "Kezdőlap";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(25, 25, 25);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(300, 80);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1282, 773);
            pnlMain.TabIndex = 18;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1582, 853);
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Controls.Add(pnlMenu);
            DoubleBuffered = true;
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1582, 853);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdatVödör";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChild).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblLogo1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo2;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnWorks;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnStatistics;
        private FontAwesome.Sharp.IconButton btnLiabilities;
        private FontAwesome.Sharp.IconButton btnAccounting;
        private FontAwesome.Sharp.IconButton btnWorkers;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblCurrentChild;
        private System.Windows.Forms.Panel pnlMain;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Button btnStartServer;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private Label lblVersion;
    }
}

