namespace DataBucket.Presenter
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            btnSave = new Button();
            groupBox5 = new GroupBox();
            label14 = new Label();
            dtpDate = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            cmbConcomitant = new ComboBox();
            cmbRepairman = new ComboBox();
            label11 = new Label();
            txtInvoice = new TextBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            label17 = new Label();
            txtFinal = new TextBox();
            label16 = new Label();
            txtDelivered = new TextBox();
            label15 = new Label();
            txtExpense = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            imgPreview = new UI.ImagePreview();
            groupBox2 = new GroupBox();
            lblReceipt = new Label();
            cbPaid = new CheckBox();
            label7 = new Label();
            txtIncome = new TextBox();
            cbTransaction = new CheckBox();
            txtMaterial = new TextBox();
            txtFuel = new TextBox();
            txtOther = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtNote = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            btnBack = new Button();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Gainsboro;
            btnSave.Location = new Point(462, 488);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 50);
            btnSave.TabIndex = 82;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(dtpDate);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(cmbConcomitant);
            groupBox5.Controls.Add(cmbRepairman);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(txtInvoice);
            groupBox5.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.Gainsboro;
            groupBox5.Location = new Point(12, 180);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 6, 3, 3);
            groupBox5.Size = new Size(560, 171);
            groupBox5.TabIndex = 91;
            groupBox5.TabStop = false;
            groupBox5.Text = "Adminisztráció";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(299, 35);
            label14.Name = "label14";
            label14.Size = new Size(66, 24);
            label14.TabIndex = 13;
            label14.Text = "Dátum";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDate.CalendarForeColor = Color.Gainsboro;
            dtpDate.CalendarMonthBackground = SystemColors.ActiveBorder;
            dtpDate.CustomFormat = "yyyy-MM-dd (dddd)";
            dtpDate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(303, 62);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(251, 32);
            dtpDate.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 105);
            label13.Name = "label13";
            label13.Size = new Size(61, 24);
            label13.TabIndex = 11;
            label13.Text = "Kísérő";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 35);
            label12.Name = "label12";
            label12.Size = new Size(70, 24);
            label12.TabIndex = 10;
            label12.Text = "Szerelő";
            // 
            // cmbConcomitant
            // 
            cmbConcomitant.BackColor = Color.FromArgb(35, 35, 35);
            cmbConcomitant.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConcomitant.FlatStyle = FlatStyle.Flat;
            cmbConcomitant.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbConcomitant.ForeColor = Color.Gainsboro;
            cmbConcomitant.FormattingEnabled = true;
            cmbConcomitant.Location = new Point(7, 132);
            cmbConcomitant.Margin = new Padding(3, 3, 3, 10);
            cmbConcomitant.Name = "cmbConcomitant";
            cmbConcomitant.Size = new Size(290, 32);
            cmbConcomitant.TabIndex = 9;
            // 
            // cmbRepairman
            // 
            cmbRepairman.BackColor = Color.FromArgb(35, 35, 35);
            cmbRepairman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepairman.FlatStyle = FlatStyle.Flat;
            cmbRepairman.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRepairman.ForeColor = Color.Gainsboro;
            cmbRepairman.FormattingEnabled = true;
            cmbRepairman.Location = new Point(6, 62);
            cmbRepairman.Margin = new Padding(3, 3, 3, 10);
            cmbRepairman.Name = "cmbRepairman";
            cmbRepairman.Size = new Size(291, 32);
            cmbRepairman.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(299, 105);
            label11.Name = "label11";
            label11.Size = new Size(110, 24);
            label11.TabIndex = 7;
            label11.Text = "Számlaszám";
            // 
            // txtInvoice
            // 
            txtInvoice.BackColor = Color.FromArgb(35, 35, 35);
            txtInvoice.BorderStyle = BorderStyle.FixedSingle;
            txtInvoice.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInvoice.ForeColor = Color.Gainsboro;
            txtInvoice.Location = new Point(303, 132);
            txtInvoice.Margin = new Padding(3, 3, 3, 10);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(251, 32);
            txtInvoice.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(txtFinal);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(txtDelivered);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtExpense);
            groupBox4.Controls.Add(txtId);
            groupBox4.Controls.Add(label3);
            groupBox4.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Gainsboro;
            groupBox4.Location = new Point(578, 250);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 6, 3, 3);
            groupBox4.Size = new Size(328, 232);
            groupBox4.TabIndex = 90;
            groupBox4.TabStop = false;
            groupBox4.Text = "Egyéb";
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(6, 171);
            label1.Name = "label1";
            label1.Size = new Size(316, 58);
            label1.TabIndex = 22;
            label1.Text = "Hozzáadás esetén az itt látható adatok üresek lehetnek";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(163, 102);
            label17.Name = "label17";
            label17.Size = new Size(60, 24);
            label17.TabIndex = 21;
            label17.Text = "Leadó";
            // 
            // txtFinal
            // 
            txtFinal.BackColor = Color.FromArgb(35, 35, 35);
            txtFinal.BorderStyle = BorderStyle.FixedSingle;
            txtFinal.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFinal.ForeColor = Color.Gainsboro;
            txtFinal.Location = new Point(167, 129);
            txtFinal.Margin = new Padding(3, 3, 3, 10);
            txtFinal.Name = "txtFinal";
            txtFinal.ReadOnly = true;
            txtFinal.Size = new Size(155, 32);
            txtFinal.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(2, 102);
            label16.Name = "label16";
            label16.Size = new Size(55, 24);
            label16.TabIndex = 19;
            label16.Text = "Bugyi";
            // 
            // txtDelivered
            // 
            txtDelivered.BackColor = Color.FromArgb(35, 35, 35);
            txtDelivered.BorderStyle = BorderStyle.FixedSingle;
            txtDelivered.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDelivered.ForeColor = Color.Gainsboro;
            txtDelivered.Location = new Point(6, 129);
            txtDelivered.Margin = new Padding(3, 3, 3, 10);
            txtDelivered.Name = "txtDelivered";
            txtDelivered.ReadOnly = true;
            txtDelivered.Size = new Size(155, 32);
            txtDelivered.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(163, 33);
            label15.Name = "label15";
            label15.Size = new Size(115, 24);
            label15.TabIndex = 5;
            label15.Text = "Össz.  kiadás";
            // 
            // txtExpense
            // 
            txtExpense.BackColor = Color.FromArgb(35, 35, 35);
            txtExpense.BorderStyle = BorderStyle.FixedSingle;
            txtExpense.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpense.ForeColor = Color.Gainsboro;
            txtExpense.Location = new Point(167, 60);
            txtExpense.Margin = new Padding(3, 3, 3, 10);
            txtExpense.Name = "txtExpense";
            txtExpense.ReadOnly = true;
            txtExpense.Size = new Size(155, 32);
            txtExpense.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(35, 35, 35);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.Gainsboro;
            txtId.Location = new Point(6, 60);
            txtId.Margin = new Padding(3, 3, 3, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(155, 32);
            txtId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 33);
            label3.Name = "label3";
            label3.Size = new Size(27, 24);
            label3.TabIndex = 3;
            label3.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(imgPreview);
            groupBox3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Gainsboro;
            groupBox3.Location = new Point(12, 357);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6, 9, 6, 6);
            groupBox3.Size = new Size(560, 125);
            groupBox3.TabIndex = 89;
            groupBox3.TabStop = false;
            groupBox3.Text = "Csatolt képek";
            // 
            // imgPreview
            // 
            imgPreview.Location = new Point(7, 38);
            imgPreview.Margin = new Padding(0);
            imgPreview.Name = "imgPreview";
            imgPreview.Size = new Size(540, 60);
            imgPreview.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblReceipt);
            groupBox2.Controls.Add(cbPaid);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtIncome);
            groupBox2.Controls.Add(cbTransaction);
            groupBox2.Controls.Add(txtMaterial);
            groupBox2.Controls.Add(txtFuel);
            groupBox2.Controls.Add(txtOther);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Gainsboro;
            groupBox2.Location = new Point(578, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 6, 3, 3);
            groupBox2.Size = new Size(328, 232);
            groupBox2.TabIndex = 88;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pénzügy";
            // 
            // lblReceipt
            // 
            lblReceipt.AutoSize = true;
            lblReceipt.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblReceipt.Location = new Point(2, 196);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(136, 28);
            lblReceipt.TabIndex = 106;
            lblReceipt.Text = "Számla: nincs";
            // 
            // cbPaid
            // 
            cbPaid.Appearance = Appearance.Button;
            cbPaid.AutoSize = true;
            cbPaid.BackColor = Color.FromArgb(60, 30, 30);
            cbPaid.CheckAlign = ContentAlignment.BottomCenter;
            cbPaid.FlatAppearance.BorderColor = Color.Gainsboro;
            cbPaid.FlatAppearance.CheckedBackColor = Color.FromArgb(30, 60, 30);
            cbPaid.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
            cbPaid.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            cbPaid.FlatStyle = FlatStyle.Flat;
            cbPaid.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbPaid.ForeColor = Color.Gainsboro;
            cbPaid.Image = Properties.Resources.crossmark3;
            cbPaid.Location = new Point(6, 142);
            cbPaid.Name = "cbPaid";
            cbPaid.Size = new Size(111, 38);
            cbPaid.TabIndex = 105;
            cbPaid.Text = "Fizetett";
            cbPaid.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbPaid.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(2, 27);
            label7.Name = "label7";
            label7.Size = new Size(72, 24);
            label7.TabIndex = 12;
            label7.Text = "Bevétel";
            // 
            // txtIncome
            // 
            txtIncome.BackColor = Color.FromArgb(35, 35, 35);
            txtIncome.BorderStyle = BorderStyle.FixedSingle;
            txtIncome.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIncome.ForeColor = Color.Gainsboro;
            txtIncome.Location = new Point(6, 54);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(155, 32);
            txtIncome.TabIndex = 11;
            // 
            // cbTransaction
            // 
            cbTransaction.Appearance = Appearance.Button;
            cbTransaction.AutoSize = true;
            cbTransaction.BackColor = Color.FromArgb(60, 30, 30);
            cbTransaction.CheckAlign = ContentAlignment.BottomCenter;
            cbTransaction.FlatAppearance.BorderColor = Color.Gainsboro;
            cbTransaction.FlatAppearance.CheckedBackColor = Color.FromArgb(30, 60, 30);
            cbTransaction.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
            cbTransaction.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            cbTransaction.FlatStyle = FlatStyle.Flat;
            cbTransaction.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbTransaction.ForeColor = Color.Gainsboro;
            cbTransaction.Image = Properties.Resources.crossmark3;
            cbTransaction.Location = new Point(6, 95);
            cbTransaction.Name = "cbTransaction";
            cbTransaction.Size = new Size(101, 38);
            cbTransaction.TabIndex = 103;
            cbTransaction.Text = "Utalás";
            cbTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbTransaction.UseVisualStyleBackColor = false;
            // 
            // txtMaterial
            // 
            txtMaterial.BackColor = Color.FromArgb(35, 35, 35);
            txtMaterial.BorderStyle = BorderStyle.FixedSingle;
            txtMaterial.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaterial.ForeColor = Color.Gainsboro;
            txtMaterial.Location = new Point(167, 54);
            txtMaterial.Margin = new Padding(3, 3, 3, 10);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(155, 32);
            txtMaterial.TabIndex = 13;
            // 
            // txtFuel
            // 
            txtFuel.BackColor = Color.FromArgb(35, 35, 35);
            txtFuel.BorderStyle = BorderStyle.FixedSingle;
            txtFuel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuel.ForeColor = Color.Gainsboro;
            txtFuel.Location = new Point(167, 123);
            txtFuel.Margin = new Padding(3, 3, 3, 10);
            txtFuel.Name = "txtFuel";
            txtFuel.Size = new Size(155, 32);
            txtFuel.TabIndex = 15;
            // 
            // txtOther
            // 
            txtOther.BackColor = Color.FromArgb(35, 35, 35);
            txtOther.BorderStyle = BorderStyle.FixedSingle;
            txtOther.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOther.ForeColor = Color.Gainsboro;
            txtOther.Location = new Point(167, 192);
            txtOther.Margin = new Padding(3, 3, 3, 10);
            txtOther.Name = "txtOther";
            txtOther.Size = new Size(155, 32);
            txtOther.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(163, 23);
            label8.Name = "label8";
            label8.Size = new Size(119, 24);
            label8.TabIndex = 14;
            label8.Text = "Anyagköltség";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(163, 96);
            label9.Name = "label9";
            label9.Size = new Size(106, 24);
            label9.TabIndex = 16;
            label9.Text = "Üzemanyag";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(163, 165);
            label10.Name = "label10";
            label10.Size = new Size(117, 24);
            label10.TabIndex = 18;
            label10.Text = "Egyéb kiadás";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Gainsboro;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 6, 3, 3);
            groupBox1.Size = new Size(560, 162);
            groupBox1.TabIndex = 87;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ügyfél";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(353, 96);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 11;
            label2.Text = "Telefonszám";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(35, 35, 35);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.ForeColor = Color.Gainsboro;
            txtPhone.Location = new Point(357, 123);
            txtPhone.Margin = new Padding(3, 3, 3, 10);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(197, 32);
            txtPhone.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(35, 35, 35);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.Gainsboro;
            txtName.Location = new Point(6, 54);
            txtName.Margin = new Padding(3, 3, 3, 10);
            txtName.Name = "txtName";
            txtName.Size = new Size(291, 32);
            txtName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(303, 27);
            label6.Name = "label6";
            label6.Size = new Size(105, 24);
            label6.TabIndex = 9;
            label6.Text = "Megjegyzés";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 27);
            label5.Name = "label5";
            label5.Size = new Size(42, 24);
            label5.TabIndex = 7;
            label5.Text = "Név";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.FromArgb(35, 35, 35);
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNote.ForeColor = Color.Gainsboro;
            txtNote.Location = new Point(303, 54);
            txtNote.Margin = new Padding(3, 3, 3, 10);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(251, 32);
            txtNote.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 96);
            label4.Name = "label4";
            label4.Size = new Size(42, 24);
            label4.TabIndex = 5;
            label4.Text = "Cím";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(35, 35, 35);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.Gainsboro;
            txtAddress.Location = new Point(6, 123);
            txtAddress.Margin = new Padding(3, 3, 3, 10);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(345, 32);
            txtAddress.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(40, 40, 40);
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Gainsboro;
            btnBack.Location = new Point(327, 488);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 50);
            btnBack.TabIndex = 92;
            btnBack.Text = "Vissza";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(14F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(918, 550);
            Controls.Add(btnBack);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Munka hozzáadása";
            Load += FormAdd_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private UI.ImagePreview imgPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbConcomitant;
        private System.Windows.Forms.ComboBox cmbRepairman;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDelivered;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.CheckBox cbTransaction;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private Label lblReceipt;
        private Label label2;
        private TextBox txtPhone;
    }
}