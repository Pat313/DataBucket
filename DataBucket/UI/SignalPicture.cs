using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBucket.UI
{
    public partial class SignalPicture : UserControl
    {
        public event EventHandler MouseClickEvent;

        public SignalPicture()
        {
            InitializeComponent();
        }
            
        private void SignalPicture_Load(object sender, EventArgs e)
        {
            pbMain.MouseClick += PictureBox_MouseClick;
            //this.MouseClick += PictureBox_MouseClick;
            pbMain.MouseEnter += PictureBox_MouseEnter;
            pbMain.MouseLeave += PictureBox_MouseLeave;
            pbMain.MouseDoubleClick += PbMain_MouseDoubleClick;
        }

        private void PbMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start("explorer.exe", ImageLocation);
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (BorderColor != Color.FromArgb(140, 100, 180))
                BorderColor = Color.FromArgb(70, 70, 70);
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (BorderColor != Color.FromArgb(140, 100, 180))
                BorderColor = Color.FromArgb(190, 190, 190);
        }

        private void PictureBox_MouseClick(object sender, EventArgs e)
        {
            MouseClickEvent?.Invoke(this, e);
            Clipboard.SetImage(pbMain.Image);
        }

        public string ImageLocation
        {
            get { return pbMain.ImageLocation; }
            set { pbMain.ImageLocation = value; }
        }

        public Color BorderColor
        {
            get { return BackColor; }
            set { BackColor = value; }
        }
    }
}
