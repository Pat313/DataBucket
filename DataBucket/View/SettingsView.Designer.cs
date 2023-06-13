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
            btnSave = new Button();
            btnDefault = new Button();
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
            cmbServerIP.Items.AddRange(new object[] { "localhost", "server_1" });
            cmbServerIP.Location = new Point(6, 33);
            cmbServerIP.Margin = new Padding(3, 3, 3, 10);
            cmbServerIP.Name = "cmbServerIP";
            cmbServerIP.Size = new Size(222, 32);
            cmbServerIP.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Gainsboro;
            btnSave.Location = new Point(644, 717);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(209, 50);
            btnSave.TabIndex = 94;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDefault
            // 
            btnDefault.BackColor = Color.FromArgb(40, 40, 40);
            btnDefault.DialogResult = DialogResult.Cancel;
            btnDefault.FlatStyle = FlatStyle.Flat;
            btnDefault.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDefault.ForeColor = Color.Gainsboro;
            btnDefault.Location = new Point(429, 717);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(209, 50);
            btnDefault.TabIndex = 100;
            btnDefault.Text = "Alapértelmezett";
            btnDefault.UseVisualStyleBackColor = false;
            // 
            // SettingsView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(btnDefault);
            Controls.Add(btnSave);
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
        private Button btnSave;
        private Button btnDefault;
    }
}
