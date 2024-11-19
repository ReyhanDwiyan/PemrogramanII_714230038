using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(297, 198);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();
            
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorMessage.AppendLine("Nama harus diisi!");
            }

            if (Angkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan harus diisi!");
            }

            if (string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                errorMessage.AppendLine("Kelas harus diisi!");
            }

            string erorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(erorMsg))
            {
                MessageBox.Show(
                "Mantap!!",
                "Berhasil!",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                Size = new Size(297, 460);
            }

            else
            {
                MessageBox.Show(
                erorMsg.Trim(),
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }


            
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekday.Checked)
            {
                checkBoxKuliah.Checked = false;
                checkBoxTidur.Checked = false;
                checkBoxLiburan.Checked = false;

                checkBoxKuliah.Enabled = true; 
                checkBoxTidur.Enabled = true; 
                checkBoxLiburan.Enabled = false; 
            }
            
        }

        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekend.Checked)
            {
                checkBoxKuliah.Checked = false;
                checkBoxLiburan.Checked = false;
                checkBoxTidur.Checked = false;

                checkBoxKuliah.Enabled = false;
                checkBoxTidur.Enabled = true;
                checkBoxLiburan.Enabled = true;

            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            String hari = null;
            string kegiatan = null;

            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    hari = radioButton.Text;
                    break;
                }
            }

            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    if (!string.IsNullOrEmpty(kegiatan))
                    {
                        kegiatan += ", ";
                    }
                    kegiatan += checkBox.Text;
                }
            }

            //MENGGUNAKAN LINQ (LEANGUAGE INTEGRATED QUERTY)

            /*string hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked)?.Text;

            string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text));*/

            MessageBox.Show(
                "Nama: " + txtName.Text + "\n" +
                "Angkatan: " + Angkatan.Text + "\n" +
                "Kelas: " + txtKelas.Text + "\n" +
                "==================================\n" +
                "Hari: " + hari + "\n" +
                "Kegiatan: " + kegiatan + "\n",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //txtName.Text = "";
            //Angkatan.SelectedIndex = -1;
            //txtKelas.Text = "";
            //radioButtonWeekday.Checked = false;
            //radioButtonWeekend.Checked = false;
            //checkBoxKuliah.Checked = false;
            //checkBoxLiburan.Checked = false;
            //checkBoxTidur.Checked = false;
            //checkBoxKuliah.Enabled = true;
            //checkBoxTidur.Enabled = true;
            //checkBoxLiburan.Enabled = true;
            

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = "";
                else if (control is RadioButton radioButton)
                {
                    radioButton.Enabled = true;
                    radioButton.Checked = false;
                }
                else if (control is ComboBox combobox)
                    combobox.SelectedIndex = -1;
                else if (control is CheckBox checkbox)
                    checkbox.Checked = false;
            }

            Size = new Size(297, 198);

            MessageBox.Show(
                "Data Berhasil Di Reset",
                "Reset",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }
    }
}
