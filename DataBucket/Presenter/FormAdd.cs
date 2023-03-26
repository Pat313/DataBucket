using System.Drawing.Imaging;

using DataBucket._Base;

namespace DataBucket.Presenter
{
    public partial class FormAdd : Form
    {
        private readonly Connection conn = Connection.Instance;

        /*[DllImport("uxtheme", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public extern static Int32 SetWindowTheme(IntPtr hWnd,
              String textSubAppName, String textSubIdList);*/

        private int selectedRepairman = 0;
        private int selectedConcomitant = 0;

        public FormAdd()
        {
            InitializeComponent();
        }

        private async void FormAdd_Load(object sender, EventArgs e)
        {
            //SetWindowTheme(dtpDate.Handle, "", "");

            cmbRepairman.DataSource = await conn.FillComboBox("worker.fullName");
            cmbConcomitant.BindingContext = new BindingContext();
            cmbConcomitant.DataSource = await conn.FillComboBox("worker.fullName");

            cmbRepairman.SelectedIndex = selectedRepairman;
            cmbConcomitant.SelectedIndex = selectedConcomitant;

            foreach (TextBox tb in Controls.OfType<TextBox>()) tb.Text = string.Empty;

            foreach (Control c in imgPreview.Controls.OfType<PictureBox>()) c.Size = new Size(60, 60);

            cbTransaction.CheckedChanged += CheckBox_CheckedChanged;
            cbReceipt.CheckedChanged += CheckBox_CheckedChanged;
            cbPaid.CheckedChanged += CheckBox_CheckedChanged;
        }

        public DateTime SelectedDate { set => dtpDate.Value = value; }
        public int SelectedRepairman { set => selectedRepairman = value; }
        public int SelectedConcomitant { set => selectedConcomitant = value; }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string date = dtpDate.Value.ToString("yyyy-MM-dd");
                string name = cmbRepairman.Text.Replace(" ", "-");
                int imageIndex = 1;

                string[] existingFiles = Directory.GetFiles(Settings.signalPath)
                    .Select(path => Path.GetFileNameWithoutExtension(path))
                    .Where(fileName => fileName.StartsWith($"{date}_{name}_"))
                    .ToArray();

                if (existingFiles.Length > 0)
                {
                    int maxImageIndex = existingFiles
                        .Select(fileName => fileName.Split('_')[2])
                        .Select(number => int.Parse(number))
                        .Max();

                    imageIndex = maxImageIndex + 1;
                }

                string[] imagerefs = imgPreview.PictureBoxes
                    .Select((pictureBox, index) =>
                    {
                        if (pictureBox.Image == null || pictureBox.Image == Settings.plusImage) return null;

                        string fileName = $"{date}_{name}_{imageIndex++:D3}";
                        pictureBox.Image.Save(Path.Combine(Settings.signalPath, $"{fileName}.jpeg"), ImageFormat.Jpeg);

                        return fileName;
                    })
                    .Where(imageref => !string.IsNullOrEmpty(imageref))
                    .ToArray();

                string result = string.Join("|", imagerefs);

                await conn.InsertWork(dtpDate.Value, txtName.Text, txtAddress.Text, txtPhone.Text, txtInvoice.Text,
                    Convert.ToInt32(txtIncome.Text), Convert.ToInt32(txtMaterial.Text), Convert.ToInt32(txtFuel.Text), Convert.ToInt32(txtOther.Text),
                    cbTransaction.Checked, cbReceipt.Checked, cbPaid.Checked, result, cmbRepairman.Text, cmbConcomitant.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba adat beszúrásakor!\n" + ex.Message);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e) =>
            (sender as CheckBox).Image = (sender as CheckBox).Checked ? Properties.Resources.checkmark3 : Properties.Resources.crossmark3;
    }
}
