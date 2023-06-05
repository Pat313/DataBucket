namespace DataBucket.View
{
    partial class SettingsView
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
            label5 = new Label();
            cmbServerIP = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(6, 6);
            label5.Name = "label5";
            label5.Size = new Size(90, 24);
            label5.TabIndex = 9;
            label5.Text = "Szerver IP";
            // 
            // cmbServerIP
            // 
            cmbServerIP.BackColor = Color.FromArgb(35, 35, 35);
            cmbServerIP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServerIP.FlatStyle = FlatStyle.Flat;
            cmbServerIP.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServerIP.ForeColor = Color.Gainsboro;
            cmbServerIP.FormattingEnabled = true;
            cmbServerIP.Items.AddRange(new object[] { "192.168.100.2", "localhost" });
            cmbServerIP.Location = new Point(6, 33);
            cmbServerIP.Margin = new Padding(3, 3, 3, 10);
            cmbServerIP.Name = "cmbServerIP";
            cmbServerIP.Size = new Size(222, 32);
            cmbServerIP.TabIndex = 10;
            // 
            // SettingsView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(cmbServerIP);
            Controls.Add(label5);
            Name = "SettingsView";
            Padding = new Padding(3);
            Size = new Size(1282, 773);
            Load += SettingsView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private ComboBox cmbServerIP;
    }
}
