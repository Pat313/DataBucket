namespace DataBucket.View
{
    partial class HomeView
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
            flpReleaseNotes = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // flpReleaseNotes
            // 
            flpReleaseNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpReleaseNotes.AutoScroll = true;
            flpReleaseNotes.BackColor = Color.FromArgb(35, 35, 35);
            flpReleaseNotes.BorderStyle = BorderStyle.FixedSingle;
            flpReleaseNotes.Location = new Point(6, 47);
            flpReleaseNotes.Name = "flpReleaseNotes";
            flpReleaseNotes.Size = new Size(625, 720);
            flpReleaseNotes.TabIndex = 119;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(249, 41);
            label1.TabIndex = 120;
            label1.Text = "Fejlesztési Napló";
            // 
            // HomeView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(label1);
            Controls.Add(flpReleaseNotes);
            Name = "HomeView";
            Padding = new Padding(3);
            Size = new Size(1282, 773);
            Load += HomeView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpReleaseNotes;
        private Label label1;
    }
}
