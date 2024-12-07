using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace UTS_714230038
{
    public partial class ChildForm : Form
    {
        
        public ChildForm()
        {
            InitializeComponent();
            Size = new Size(836, 257);

            MtkDiskrit.Enabled = false;
            AljabarLinear.Enabled = false;
            Pemrograman1.Enabled = false;
            Pemrograman2.Enabled = false;
            LiterasiTeknologi.Enabled = false;
            BasisData1.Enabled = false;
            BasisData2.Enabled = false;
            LiterasiData.Enabled = false;
            Algoritma1.Enabled = false;
            Algoritma2.Enabled = false;
            PendidikanPancasila.Enabled = false;
            SCM.Enabled = false;
        }


        private void SetErrorMesseges(TextBox textBox, string wrongMessage, string warningMessage)
        {
            epWrong.SetError(textBox, wrongMessage);
            epWarning.SetError(textBox, warningMessage);
        }

        

        private void Npm_Leave(object sender, EventArgs e)
        {

            if (Npm.Text == "")
            {
                SetErrorMesseges(Npm, "", "Harap Isi NPM");
            }

            else if (Npm.Text.Any(Char.IsLetter))
            {
                SetErrorMesseges(Npm, "Npm hanya bisa diisi dengan Angka!", "");
            }
            else
            {
                epWrong.SetError(Npm, "");
                epWarning.SetError(Npm, "");
            }
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Perempuan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LakiLaki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PilihMatkul_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(Nama.Text))
            {
                errorMessage.AppendLine("Nama harus diisi!");
            }

            if (!LakiLaki.Checked && !Perempuan.Checked)
            {
                errorMessage.AppendLine("Jenis Kelamin Harus Diisi!");
            }

            if (string.IsNullOrWhiteSpace(Npm.Text))
            {
                errorMessage.AppendLine("NPM harus diisi!");
            }

            if (ProgramStudi.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Program Studi harus diisi!");
            }

            if (string.IsNullOrWhiteSpace(Alamat.Text))
            {
                errorMessage.AppendLine("Alamat harus diisi!");
            }

            if (string.IsNullOrWhiteSpace(TahunAkademik.Text))
            {
                errorMessage.AppendLine("Tahun Akademik harus diisi!");
            }



            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString(), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Jika ada error, keluar dari fungsi
            }

            // Validasi format
            if (!Regex.IsMatch(Npm.Text, @"^\d+$"))  // NPM harus hanya angka
            {
                MessageBox.Show("NPM harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!Regex.IsMatch(Nama.Text, @"^[a-zA-Z ]+$"))  // Nama hanya bisa huruf dan spasi
            {
                MessageBox.Show("Nama hanya bisa diisi dengan huruf.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(TahunAkademik.Text, @"^\d{4}/\d{4}$"))  // Format Tahun Akademik: 0000/0000
            {
                MessageBox.Show("Tahun Akademik tidak valid! Gunakan format 0000/0000.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Jika semua validasi lulus, lanjutkan dengan aksi
            MessageBox.Show("Lengkap!", "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Size = new Size(836, 495);

            
    }

        private void Nama_Leave(object sender, EventArgs e)
        {
            if (Nama.Text == "")
            {
                SetErrorMesseges(Nama, "", "Harap Isi Nama");
            }

            else if (Nama.Text.Any(Char.IsNumber))
            {
                SetErrorMesseges(Nama, "Nama hanya bisa diisi dengan Huruf!", "");
            }
            else
            {
                epWrong.SetError(Nama, "");
                epWarning.SetError(Nama, "");
            }
        }

        private void Alamat_Leave(object sender, EventArgs e)
        {
            if (Alamat.Text == "")
            {
                SetErrorMesseges(Alamat, "", "Harap Isi Alamat");
            }

            else
            {
                epWrong.SetError(Alamat, "");
                epWarning.SetError(Alamat, "");
            }
        }

        private void TahunAkademik_Leave(object sender, EventArgs e)
        {
            if (TahunAkademik.Text == "")
            {
                SetErrorMesseges(TahunAkademik, "", "Harap Isi Tahun Akademik");
            }

            else if (!Regex.IsMatch(TahunAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                SetErrorMesseges(TahunAkademik, "Format Tahun Akademik tidak valid! Gunakan format 0000/0000.", "");
            }
            else
            {
                epWrong.SetError(TahunAkademik, "");
                epWarning.SetError(TahunAkademik, "");
            }
        }

        private void Kelas_Leave(object sender, EventArgs e)
        {
            if (Kelas.Text == "")
            {
                SetErrorMesseges(Kelas, "", "Harap Isi Kelas");
            }

            else if (Kelas.Text.All(Char.IsLetter))
            {
                SetErrorMesseges(Kelas, "Kelas hanya bisa diisi dengan Angka!", "");
            }

            else
            {
                epWrong.SetError(Kelas, "");
                epWarning.SetError(Kelas, "");
            }
        }

        
        private void Sem1_CheckedChanged(object sender, EventArgs e)
        {
            //Mtk diskrit, Aljabar linear, pemrograman1, pemrograman2, Literasi Teknologi, Basis data1, basis data 2, literasi data, algo1, algo2, pkn, SCM
            //Literasi Data, Pendidikan Pancasila, Pemrograman I, Algoritma dan Struktur Data1, Matematika Diskrit
            if (Sem1.Checked)
            {
                MtkDiskrit.Checked = false;
                AljabarLinear.Checked = false;
                Pemrograman1.Checked = false;
                Pemrograman2.Checked = false;
                LiterasiTeknologi.Checked = false;
                BasisData1.Checked = false;
                BasisData2.Checked = false;
                LiterasiData.Checked = false;
                Algoritma1.Checked = false;
                Algoritma2.Checked = false;
                PendidikanPancasila.Checked = false;
                SCM.Checked = false;

                MtkDiskrit.Enabled = true;
                AljabarLinear.Enabled = false;
                Pemrograman1.Enabled = true;
                Pemrograman2.Enabled = false;
                LiterasiTeknologi.Enabled = false;
                BasisData1.Enabled = false;
                BasisData2.Enabled = false;
                LiterasiData.Enabled = true;
                Algoritma1.Enabled = true;
                Algoritma2.Enabled = false;
                PendidikanPancasila.Enabled = true;
                SCM.Enabled = false;
            }

            
        }

        private void Sem2_CheckedChanged(object sender, EventArgs e)
        {
            if (Sem2.Checked)
            {
                Pemrograman1.Checked = false;
                Pemrograman2.Checked = false;
                LiterasiTeknologi.Checked = false;
                BasisData1.Checked = false;
                BasisData2.Checked = false;
                LiterasiData.Checked = false;
                Algoritma1.Checked = false;
                Algoritma2.Checked = false;
                PendidikanPancasila.Checked = false;
                SCM.Checked = false;

                MtkDiskrit.Enabled = false;
                AljabarLinear.Enabled = true;
                Pemrograman1.Enabled = false;
                Pemrograman2.Enabled = false;
                LiterasiTeknologi.Enabled = true;
                BasisData1.Enabled = true;
                BasisData2.Enabled = false;
                LiterasiData.Enabled = false;
                Algoritma1.Enabled = false;
                Algoritma2.Enabled = false;
                PendidikanPancasila.Enabled = false;
                SCM.Enabled = true;
            }
        }

        private void Sem3_CheckedChanged(object sender, EventArgs e)
        {
            Pemrograman1.Checked = false;
            Pemrograman2.Checked = false;
            LiterasiTeknologi.Checked = false;
            BasisData1.Checked = false;
            BasisData2.Checked = false;
            LiterasiData.Checked = false;
            Algoritma1.Checked = false;
            Algoritma2.Checked = false;
            PendidikanPancasila.Checked = false;
            SCM.Checked = false;

            MtkDiskrit.Enabled = false;
            AljabarLinear.Enabled = false;
            Pemrograman1.Enabled = false;
            Pemrograman2.Enabled = true;
            LiterasiTeknologi.Enabled = false;
            BasisData1.Enabled = false;
            BasisData2.Enabled = true;
            LiterasiData.Enabled = false;
            Algoritma1.Enabled = false;
            Algoritma2.Enabled = true;
            PendidikanPancasila.Enabled = false;
            SCM.Enabled = false;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            String semester = null;
            String matkul = null;
            String jeniskelamin = null;

            foreach (Control control in Semester.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    semester = radioButton.Text;
                    break;
                }
            }

            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    jeniskelamin = radioButton.Text;
                    break;
                }
            }

            foreach (Control control in MatkulPilihan.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    if (!string.IsNullOrEmpty(matkul))
                    {
                        matkul += ", ";
                    }
                    matkul += checkBox.Text;
                }
            }
            
            MessageBox.Show(
                "NPM: " + Npm.Text + "\n" +
                "Nama: " + Nama.Text + "\n" +
                "Jenis Kelamin: " + jeniskelamin + "\n" +
                "Alamat: " + Alamat.Text + "\n" +
                "Program Studi: " + ProgramStudi.Text + "\n" +
                "Tahun Akademik: " + TahunAkademik.Text + "\n" +
                "Kelas: " + Kelas.Text + "\n" +
                "==================================\n" +
                "Kurikulum: " +semester + "\n" +
                "Mata Kuliah : " + matkul + "\n",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
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

            foreach (Control control in Semester.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Enabled = true;
                    radioButton.Checked = false;
                }
            }

            foreach (Control control in MatkulPilihan.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Enabled = false;
                    checkBox.Checked = false;
                }
            }

            Size = new Size(836, 257);

            MessageBox.Show(
                "Form Telah Direset",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }
    }
}
