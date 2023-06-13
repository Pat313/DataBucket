namespace DataBucket.UI
{
    partial class ReleaseNote
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
            txtNote = new RichTextBox();
            SuspendLayout();
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtNote.BackColor = Color.FromArgb(35, 35, 35);
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.ForeColor = Color.Gainsboro;
            txtNote.Location = new Point(140, 10);
            txtNote.Margin = new Padding(0);
            txtNote.MaxLength = 185;
            txtNote.Name = "txtNote";
            txtNote.ReadOnly = true;
            txtNote.ScrollBars = RichTextBoxScrollBars.None;
            txtNote.Size = new Size(450, 44);
            txtNote.TabIndex = 0;
            txtNote.Text = "";
            // 
            // ReleaseNote
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(35, 35, 35);
            Controls.Add(txtNote);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            Margin = new Padding(0);
            Name = "ReleaseNote";
            Padding = new Padding(10);
            Size = new Size(600, 64);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtNote;
    }
}
