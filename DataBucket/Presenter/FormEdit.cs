using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataBucket._Base;
using static DataBucket.Settings;

namespace DataBucket.Presenter
{
    public partial class FormEdit : Form
    {
        private readonly Connection conn = Connection.Instance;

        private readonly int selectedId = 0;
        private readonly List<PictureBox> loadedImages = new List<PictureBox>();
        private List<string> loadedRefs = new List<string>();

        public FormEdit(int id)
        {
            InitializeComponent();
            selectedId = id;
        }

        private async void FormEdit_Load(object sender, EventArgs e)
        {
            cmbRepairman.DataSource = await conn.FillComboBox("worker.fullName");
            cmbConcomitant.BindingContext = new BindingContext();
            cmbConcomitant.DataSource = await conn.FillComboBox("worker.fullName");

            foreach (Control c in imgPreview.Controls.OfType<PictureBox>()) c.Size = new Size(60, 60);

            // checkbox event handlers up here because of icon change
            cbTransaction.CheckedChanged += CheckBox_CheckedChanged;
            //cbReceipt.CheckedChanged += CheckBox_CheckedChanged;
            cbPaid.CheckedChanged += CheckBox_CheckedChanged;

            txtInvoice.TextChanged += txtInvoice_TextChanged;

            btnSave.Click += btnSave_Click;

            object[] data = await conn.LoadAllById(selectedId);

            txtId.Text = data[0].ToString();
            dtpDate.Value = (DateTime)data[1];
            txtName.Text = (string)data[2];
            txtAddress.Text = (string)data[3];
            txtPhone.Text = (string)data[4];
            txtNote.Text = (string)data[5];
            txtInvoice.Text = (string)data[6];
            txtIncome.Text = data[7].ToString();
            txtMaterial.Text = data[8].ToString();
            txtFuel.Text = data[9].ToString();
            txtOther.Text = data[10].ToString();
            txtExpense.Text = data[11].ToString();
            cbTransaction.Checked = (bool)data[12];
            //cbReceipt.Checked = (bool)data[13];
            cbPaid.Checked = (bool)data[14];
            txtDelivered.Text = data[15].ToString();
            txtFinal.Text = data[16].ToString();
            loadedRefs = data[17].ToString().Split('|').ToList();
            cmbRepairman.SelectedIndex = (int)data[18] - 1;
            cmbConcomitant.SelectedIndex = (int)data[19] - 1;

            // image refs
            for (int i = 0; i < loadedRefs.Count; i++)
            {
                imgPreview.PictureBoxes[i].Image = Image.FromFile(Path.Combine(signalPath, loadedRefs[i] + ".jpeg"));
                loadedImages.Add(imgPreview.PictureBoxes[i]);
            }
            imgPreview.PictureBoxes[loadedRefs.Count].Image = plusImage;
        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                string result = string.Empty;
                bool imagesMatch = loadedImages
                    .Select((pb, i) => pb.Image == imgPreview.PictureBoxes[i].Image)
                    .All(x => x);

                if (!imagesMatch)
                {
                    string date = dtpDate.Value.ToString("yyyy-MM-dd");
                    string name = cmbRepairman.Text.Replace(" ", "-");
                    int imageIndex = 1;

                    foreach (var imageref in loadedRefs)
                        File.Delete(Path.Combine(Settings.signalPath, imageref));

                    string[] existingFiles = imagesMatch ? new string[0] :
                        Directory.GetFiles(Settings.signalPath)
                            .Select(path => Path.GetFileNameWithoutExtension(path))
                            .Where(fileName => fileName.StartsWith($"{date}_{name}_"))
                            .ToArray();

                    if (existingFiles.Length > 0)
                        imageIndex = existingFiles
                            .Select(fileName => fileName.Split('_')[2])
                            .Select(number => int.Parse(number))
                            .Max();

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

                    result = string.Join("|", imagerefs);
                }
                else result = string.Join("|", loadedRefs);

                await conn.UpdateWork(dtpDate.Value, txtName.Text, txtAddress.Text, txtPhone.Text, txtNote.Text, txtInvoice.Text,
                    GetMoneyValue(txtIncome), GetMoneyValue(txtMaterial), GetMoneyValue(txtFuel), GetMoneyValue(txtOther),
                    cbTransaction.Checked, cbPaid.Checked, result, cmbRepairman.Text, cmbConcomitant.Text, selectedId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba adat frissítésekor!\n" + ex.Message);
            }
        }

        private int GetMoneyValue(TextBox tb) => int.TryParse(tb.Text, out int res) ? res : 0;

        private void CheckBox_CheckedChanged(object? sender, EventArgs e) =>
            ((CheckBox)sender).Image = ((CheckBox)sender).Checked ? Properties.Resources.checkmark3 : Properties.Resources.crossmark3;

        private void txtInvoice_TextChanged(object? sender, EventArgs e)
        {
            if (txtInvoice.Text.Length > 0) lblReceipt.Text = "Számla: van";
            else lblReceipt.Text = "Számla: nincs";
        }
    }
}
