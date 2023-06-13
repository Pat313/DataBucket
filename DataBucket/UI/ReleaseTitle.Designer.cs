namespace DataBucket.UI
{
    partial class ReleaseTitle
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
            lblDate = new Label();
            lblVersion = new Label();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(10, 30);
            lblDate.Margin = new Padding(0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 35);
            lblDate.TabIndex = 0;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.Location = new Point(10, 65);
            lblVersion.Margin = new Padding(0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(0, 28);
            lblVersion.TabIndex = 1;
            // 
            // ReleaseTitle
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(lblVersion);
            Controls.Add(lblDate);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            Margin = new Padding(0);
            Name = "ReleaseTitle";
            Padding = new Padding(10, 30, 10, 15);
            Size = new Size(600, 108);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private Label lblVersion;
    }
}
