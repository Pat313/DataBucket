using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Net;

using FontAwesome.Sharp;

using Microsoft.Win32;

using DataBucket.View;
using DataBucket.UI;

namespace DataBucket.Presenter
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private bool menuCollapsed = false;
        private System.Windows.Forms.Timer animationTimer;
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.SetStyle(ControlStyles.ResizeRedraw, true);

            leftBorderBtn = new Panel { Size = new Size(7, 80) };
            pnlMenu.Controls.Add(leftBorderBtn);

            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //animationTimer = new Timer { Interval = 15 };
            //animationTimer.Tick += AnimationTimer_Tick;

            btnHome.Click += btnHome_Click;
            btnWorkers.Click += btnWorkers_Click;
            btnWorks.Click += btnWorks_Click;
            btnAccounting.Click += btnAccounting_Click;
            btnLiabilities.Click += btnLiabilities_Click;
            btnStatistics.Click += btnStatistics_Click;
            btnSettings.Click += btnSettings_Click;

            btnMenu.MouseEnter += btnMenu_MouseEnter;
            btnMenu.MouseLeave += btnMenu_MouseLeave;
            btnMenu.Click += btnMenu_Click;

            pnlTitle.MouseDown += pnlTitle_MouseDown;

            btnMinimize.Click += btnMinimize_Click;
            btnMaximize.Click += btnMaximize_Click;
            btnExit.Click += btnExit_Click;

            btnStartServer.Click += btnStartServer_Click;

            /*lblVersion.MouseEnter += lblVersion_MouseEnter;
            lblVersion.MouseLeave += lblVersion_MouseLeave;
            lblVersion.MouseClick += lblVersion_MouseClick;*/

            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += Form_Disposed;

            LoadViews();

            LoadTheme();

            using (StreamReader reader = new StreamReader(Path.Combine(Settings.rootPath, "changelog.md")))
                lblVersion.Text = reader.ReadLine().Split(' ')[1];
        }

        private void LoadViews()
        {
            pnlMain.Controls.Add(HomeView.Instance);
            pnlMain.Controls.Add(WorkView.Instance);
            pnlMain.Controls.Add(WorkerView.Instance);
            pnlMain.Controls.Add(AccountingView.Instance);
            pnlMain.Controls.Add(LiabilitiesView.Instance);
            pnlMain.Controls.Add(StatisticsView.Instance);
            pnlMain.Controls.Add(SettingsView.Instance);

            /*btnWorks.PerformClick();
            btnWorkers.PerformClick();
            btnAccounting.PerformClick();
            btnLiabilities.PerformClick();
            btnStatistics.PerformClick();
            btnSettings.PerformClick();*/
            btnHome.PerformClick();
        }

        private void LoadTheme()
        {
            var themeColor = WinTheme.GetAccentColor();
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);

            foreach (var control in Controls.OfType<Label>())
                control.ForeColor = lightColor;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }

        private void Form_Disposed(object? sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;

        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            const int step = 10;
            int targetWidth = menuCollapsed ? 100 : 300;
            int currentWidth = pnlMenu.Width;
            int newWidth;

            if (menuCollapsed)
            {
                if (currentWidth > targetWidth)
                {
                    newWidth = Math.Max(currentWidth - step, targetWidth);
                    pnlMenu.Width = newWidth;
                }
                else
                {
                    animationTimer.Stop();
                    pnlMain.ResumeLayout();
                }
            }
            else
            {
                if (currentWidth < targetWidth)
                {
                    newWidth = Math.Min(currentWidth + step, targetWidth);
                    pnlMenu.Width = newWidth;
                }
                else
                {
                    animationTimer.Stop();
                    pnlMain.ResumeLayout();
                }
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(126, 184, 57);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(167, 91, 205);
            public static Color color5 = Color.FromArgb(48, 199, 163);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(206, 98, 115);
        }

        private struct ButtonNames
        {
            public static string home = "Kezdőlap";
            public static string work = "Munkák";
            public static string worker = "Munkavállalók";
            public static string accounting = "Elszámolás";
            public static string liabilities = "Követelések";
            public static string statistics = "Statisztika";
            public static string settings = "Beállítások";
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(40, 40, 40);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChild.IconChar = currentBtn.IconChar;
                iconCurrentChild.IconColor = color;
                lblCurrentChild.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 30, 30);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            HomeView.Instance.BringToFront();
            lblCurrentChild.Text = ButtonNames.home;
        }

        private void btnWorks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            //if (!pnlMain.Controls.Contains(WorkView.Instance)) pnlMain.Controls.Add(WorkView.Instance);
            WorkView.Instance.BringToFront();
            //WorkView.Instance.Show();
            lblCurrentChild.Text = ButtonNames.work;
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            WorkerView.Instance.BringToFront();
            lblCurrentChild.Text = ButtonNames.worker;
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AccountingView.Instance.BringToFront();
            lblCurrentChild.Text = ButtonNames.accounting;
        }

        private void btnLiabilities_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            LiabilitiesView.Instance.BringToFront();
            lblCurrentChild.Text = ButtonNames.liabilities;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            StatisticsView.Instance.BringToFront();
            lblCurrentChild.Text = ButtonNames.statistics;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            SettingsView.Instance.BringToFront();
            lblCurrentChild.Text = ButtonNames.settings;
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.IconColor = Color.DodgerBlue;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.IconColor = Color.Gainsboro;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //pnlMain.SuspendLayout();
            if (!menuCollapsed)
            {
                menuCollapsed = true;
                //animationTimer.Start();
                pnlMenu.Width = 100;
                btnHome.Text = "";
                btnWorks.Text = "";
                btnWorkers.Text = "";
                btnAccounting.Text = "";
                btnLiabilities.Text = "";
                btnStatistics.Text = "";
                btnSettings.Text = "";
                pbLogo.Visible = false;
                lblLogo1.Visible = false;
                lblLogo2.Visible = false;
            }
            else
            {
                menuCollapsed = false;
                //animationTimer.Start();
                pnlMenu.Width = 300;
                btnHome.Text = ButtonNames.home;
                btnWorks.Text = ButtonNames.work;
                btnWorkers.Text = ButtonNames.worker;
                btnAccounting.Text = ButtonNames.accounting;
                btnLiabilities.Text = ButtonNames.liabilities;
                btnStatistics.Text = ButtonNames.statistics;
                btnSettings.Text = ButtonNames.settings;
                pbLogo.Visible = true;
                lblLogo1.Visible = true;
                lblLogo2.Visible = true;
            }
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.IconChar = IconChar.WindowMaximize;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                using (WebResponse response = await WebRequest.Create("http://127.0.0.1/site").GetResponseAsync())
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = @"D:\xampp\xampp-control.exe",
                        WindowStyle = ProcessWindowStyle.Hidden, // tray
                        UseShellExecute = true, // UAC
                        Verb = "runas" // admin
                    });
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("A szerver már fut!\n" + ex);
            }
        }

        private void lblVersion_MouseEnter(object? sender, EventArgs e)
        {
            lblVersion.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void lblVersion_MouseLeave(object? sender, EventArgs e)
        {
            lblVersion.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void lblVersion_MouseClick(object? sender, MouseEventArgs e)
        {
            lblVersion.BackColor = Color.FromArgb(45, 45, 45);

            // check for updates -> change to button later
        }

        /*protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }*/
    }
}