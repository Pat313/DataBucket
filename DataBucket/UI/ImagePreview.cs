using DataBucket.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static DataBucket.Settings;

namespace DataBucket.UI
{
    public partial class ImagePreview : UserControl
    {
        // Fields
        private List<PictureBox> pictureBoxes;
        private Image tempImage;
        
        public event EventHandler ClipboardIsEmpty;

        public ImagePreview()
        {
            InitializeComponent();
        }

        private void ImagePreview_Load(object sender, EventArgs e)
        {
            PictureBoxes = new List<PictureBox> { pbPreview0, pbPreview1, pbPreview2, pbPreview3, pbPreview4, 
                pbPreview5, pbPreview6, pbPreview7, pbPreview8, pbPreview9 };

            pbPreview0.Image = plusImage;
        }

        #region Properties
        /*public Image Pre0 { get => pbPreview0.Image; set => pbPreview0.Image = value; }
        public Image Pre1 { get => pbPreview1.Image; set => pbPreview1.Image = value; }
        public Image Pre2 { get => pbPreview2.Image; set => pbPreview2.Image = value; }
        public Image Pre3 { get => pbPreview3.Image; set => pbPreview3.Image = value; }
        public Image Pre4 { get => pbPreview4.Image; set => pbPreview4.Image = value; }
        public Image Pre5 { get => pbPreview5.Image; set => pbPreview5.Image = value; }
        public Image Pre6 { get => pbPreview6.Image; set => pbPreview6.Image = value; }
        public Image Pre7 { get => pbPreview7.Image; set => pbPreview7.Image = value; }
        public Image Pre8 { get => pbPreview8.Image; set => pbPreview8.Image = value; }
        public Image Pre9 { get => pbPreview9.Image; set => pbPreview9.Image = value; }*/
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<PictureBox> PictureBoxes { get => pictureBoxes; set => pictureBoxes = value; }
        #endregion

        #region Private methods
        private void HandleClipboardIsEmpty(object sender, EventArgs e)
        {
            // we'll explain this in a minute
            this.OnClipboardIsEmpty(EventArgs.Empty);
        }

        protected virtual void OnClipboardIsEmpty(EventArgs e)
        {
            this.ClipboardIsEmpty?.Invoke(this, e);
        }

        /*private PictureBox GetNextPictureBox(PictureBox pictureBox)
        {
            var nextIndex = PictureBoxes.IndexOf(pictureBox) + 1;
            if (nextIndex >= PictureBoxes.Count)
                nextIndex = 0;
            return PictureBoxes[nextIndex];
        }*/

        private void SetAdjacentPictureBoxImage(PictureBox pictureBox, Image image)
        {
            int adjacentIndex = PictureBoxes.IndexOf(pictureBox) + 1;
            if (adjacentIndex < PictureBoxes.Count)
                PictureBoxes[adjacentIndex].Image = image;
        }

        private void BringToEnd(PictureBox pictureBox)
        {
            int index = PictureBoxes.IndexOf(pictureBox);
            if (index >= 0 && index != PictureBoxes.Count - 1)
            {
                PictureBoxes.RemoveAt(index);
                PictureBoxes.Add(pictureBox);
            }
        }

        private void PictureboxClicked(PictureBox pb)
        {
            if (pb.Image == minusImage)
            {
                pb.Image = PictureBoxes.IndexOf(pb) == 9 ? plusImage : null; // Count works better but it keeps the plus
                pb.BringToFront();
                BringToEnd(pb);
            }
            else if (pb.Image == plus2Image)
            {
                if (Clipboard.ContainsImage())
                {
                    pb.Image = Clipboard.GetImage();
                    SetAdjacentPictureBoxImage(pb, plusImage);
                }
                else
                {
                    MessageBox.Show("Nem található kép a vágólapon!");
                    //return;
                }
            }
        }

        private void PictureboxEntered(PictureBox pb)
        {
            if (pb.Image == plusImage) pb.Image = plus2Image;
            else if (pb.Image != null && pb.Image != plusImage)
            {
                tempImage = pb.Image;
                pb.Image = minusImage;
            }
        }

        private void PictureboxLeft(PictureBox pb)
        {
            if (pb.Image == minusImage) pb.Image = tempImage;
            else if (pb.Image == plus2Image) pb.Image = plusImage;
        }
        #endregion

        #region Events
        private void pbPreview1_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview2_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview3_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview4_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview5_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview6_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview7_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview8_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview9_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview10_MouseClick(object sender, EventArgs e) => PictureboxClicked((PictureBox)sender);
        private void pbPreview1_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview2_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview3_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview4_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview5_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview6_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview7_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview8_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview9_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview10_MouseEnter(object sender, EventArgs e) => PictureboxEntered((PictureBox)sender);
        private void pbPreview1_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview2_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview3_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview4_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview5_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview6_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview7_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview8_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview9_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        private void pbPreview10_MouseLeave(object sender, EventArgs e) => PictureboxLeft((PictureBox)sender);
        #endregion
    }
}
