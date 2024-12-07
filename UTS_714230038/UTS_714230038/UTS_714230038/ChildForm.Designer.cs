namespace UTS_714230038
{
    partial class ChildForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Npm = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.TahunAkademik = new System.Windows.Forms.TextBox();
            this.Kelas = new System.Windows.Forms.TextBox();
            this.LakiLaki = new System.Windows.Forms.RadioButton();
            this.Perempuan = new System.Windows.Forms.RadioButton();
            this.ProgramStudi = new System.Windows.Forms.ComboBox();
            this.PilihMatkul = new System.Windows.Forms.Button();
            this.Semester = new System.Windows.Forms.GroupBox();
            this.Sem3 = new System.Windows.Forms.RadioButton();
            this.Sem2 = new System.Windows.Forms.RadioButton();
            this.Sem1 = new System.Windows.Forms.RadioButton();
            this.MatkulPilihan = new System.Windows.Forms.GroupBox();
            this.SCM = new System.Windows.Forms.CheckBox();
            this.PendidikanPancasila = new System.Windows.Forms.CheckBox();
            this.Algoritma2 = new System.Windows.Forms.CheckBox();
            this.Algoritma1 = new System.Windows.Forms.CheckBox();
            this.LiterasiData = new System.Windows.Forms.CheckBox();
            this.BasisData2 = new System.Windows.Forms.CheckBox();
            this.BasisData1 = new System.Windows.Forms.CheckBox();
            this.LiterasiTeknologi = new System.Windows.Forms.CheckBox();
            this.Pemrograman2 = new System.Windows.Forms.CheckBox();
            this.Pemrograman1 = new System.Windows.Forms.CheckBox();
            this.AljabarLinear = new System.Windows.Forms.CheckBox();
            this.MtkDiskrit = new System.Windows.Forms.CheckBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnBatal = new System.Windows.Forms.Button();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.Semester.SuspendLayout();
            this.MatkulPilihan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Program Studi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tahun Akademik";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kelas";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Npm
            // 
            this.Npm.Location = new System.Drawing.Point(144, 60);
            this.Npm.Margin = new System.Windows.Forms.Padding(2);
            this.Npm.Name = "Npm";
            this.Npm.Size = new System.Drawing.Size(175, 20);
            this.Npm.TabIndex = 8;
            this.Npm.Leave += new System.EventHandler(this.Npm_Leave);
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(144, 84);
            this.Nama.Margin = new System.Windows.Forms.Padding(2);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(175, 20);
            this.Nama.TabIndex = 9;
            this.Nama.Leave += new System.EventHandler(this.Nama_Leave);
            // 
            // Alamat
            // 
            this.Alamat.Location = new System.Drawing.Point(144, 133);
            this.Alamat.Margin = new System.Windows.Forms.Padding(2);
            this.Alamat.Multiline = true;
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(175, 58);
            this.Alamat.TabIndex = 10;
            this.Alamat.Leave += new System.EventHandler(this.Alamat_Leave);
            // 
            // TahunAkademik
            // 
            this.TahunAkademik.Location = new System.Drawing.Point(604, 90);
            this.TahunAkademik.Margin = new System.Windows.Forms.Padding(2);
            this.TahunAkademik.Name = "TahunAkademik";
            this.TahunAkademik.Size = new System.Drawing.Size(164, 20);
            this.TahunAkademik.TabIndex = 11;
            this.TahunAkademik.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.TahunAkademik.Leave += new System.EventHandler(this.TahunAkademik_Leave);
            // 
            // Kelas
            // 
            this.Kelas.Location = new System.Drawing.Point(604, 122);
            this.Kelas.Margin = new System.Windows.Forms.Padding(2);
            this.Kelas.Name = "Kelas";
            this.Kelas.Size = new System.Drawing.Size(164, 20);
            this.Kelas.TabIndex = 12;
            this.Kelas.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.Kelas.Leave += new System.EventHandler(this.Kelas_Leave);
            // 
            // LakiLaki
            // 
            this.LakiLaki.AutoSize = true;
            this.LakiLaki.Location = new System.Drawing.Point(144, 110);
            this.LakiLaki.Margin = new System.Windows.Forms.Padding(2);
            this.LakiLaki.Name = "LakiLaki";
            this.LakiLaki.Size = new System.Drawing.Size(70, 17);
            this.LakiLaki.TabIndex = 13;
            this.LakiLaki.TabStop = true;
            this.LakiLaki.Text = "Laki - laki";
            this.LakiLaki.UseVisualStyleBackColor = true;
            this.LakiLaki.CheckedChanged += new System.EventHandler(this.LakiLaki_CheckedChanged);
            // 
            // Perempuan
            // 
            this.Perempuan.AutoSize = true;
            this.Perempuan.Location = new System.Drawing.Point(214, 110);
            this.Perempuan.Margin = new System.Windows.Forms.Padding(2);
            this.Perempuan.Name = "Perempuan";
            this.Perempuan.Size = new System.Drawing.Size(79, 17);
            this.Perempuan.TabIndex = 14;
            this.Perempuan.TabStop = true;
            this.Perempuan.Text = "Perempuan";
            this.Perempuan.UseVisualStyleBackColor = true;
            this.Perempuan.CheckedChanged += new System.EventHandler(this.Perempuan_CheckedChanged);
            // 
            // ProgramStudi
            // 
            this.ProgramStudi.FormattingEnabled = true;
            this.ProgramStudi.Items.AddRange(new object[] {
            "D3 Teknik Informatika",
            "D4 Teknik Informatika"});
            this.ProgramStudi.Location = new System.Drawing.Point(604, 58);
            this.ProgramStudi.Margin = new System.Windows.Forms.Padding(2);
            this.ProgramStudi.Name = "ProgramStudi";
            this.ProgramStudi.Size = new System.Drawing.Size(164, 21);
            this.ProgramStudi.TabIndex = 15;
            // 
            // PilihMatkul
            // 
            this.PilihMatkul.Location = new System.Drawing.Point(639, 162);
            this.PilihMatkul.Margin = new System.Windows.Forms.Padding(2);
            this.PilihMatkul.Name = "PilihMatkul";
            this.PilihMatkul.Size = new System.Drawing.Size(127, 28);
            this.PilihMatkul.TabIndex = 16;
            this.PilihMatkul.Text = "Pilih Mata Kuliah";
            this.PilihMatkul.UseVisualStyleBackColor = true;
            this.PilihMatkul.Click += new System.EventHandler(this.PilihMatkul_Click);
            // 
            // Semester
            // 
            this.Semester.Controls.Add(this.Sem3);
            this.Semester.Controls.Add(this.Sem2);
            this.Semester.Controls.Add(this.Sem1);
            this.Semester.Location = new System.Drawing.Point(81, 265);
            this.Semester.Margin = new System.Windows.Forms.Padding(2);
            this.Semester.Name = "Semester";
            this.Semester.Padding = new System.Windows.Forms.Padding(2);
            this.Semester.Size = new System.Drawing.Size(133, 144);
            this.Semester.TabIndex = 17;
            this.Semester.TabStop = false;
            this.Semester.Text = "Semester";
            this.Semester.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Sem3
            // 
            this.Sem3.AutoSize = true;
            this.Sem3.Location = new System.Drawing.Point(13, 92);
            this.Sem3.Margin = new System.Windows.Forms.Padding(2);
            this.Sem3.Name = "Sem3";
            this.Sem3.Size = new System.Drawing.Size(78, 17);
            this.Sem3.TabIndex = 2;
            this.Sem3.TabStop = true;
            this.Sem3.Text = "Semester 3";
            this.Sem3.UseVisualStyleBackColor = true;
            this.Sem3.CheckedChanged += new System.EventHandler(this.Sem3_CheckedChanged);
            // 
            // Sem2
            // 
            this.Sem2.AutoSize = true;
            this.Sem2.Location = new System.Drawing.Point(13, 58);
            this.Sem2.Margin = new System.Windows.Forms.Padding(2);
            this.Sem2.Name = "Sem2";
            this.Sem2.Size = new System.Drawing.Size(78, 17);
            this.Sem2.TabIndex = 1;
            this.Sem2.TabStop = true;
            this.Sem2.Text = "Semester 2";
            this.Sem2.UseVisualStyleBackColor = true;
            this.Sem2.CheckedChanged += new System.EventHandler(this.Sem2_CheckedChanged);
            // 
            // Sem1
            // 
            this.Sem1.AutoSize = true;
            this.Sem1.Location = new System.Drawing.Point(13, 25);
            this.Sem1.Margin = new System.Windows.Forms.Padding(2);
            this.Sem1.Name = "Sem1";
            this.Sem1.Size = new System.Drawing.Size(78, 17);
            this.Sem1.TabIndex = 0;
            this.Sem1.TabStop = true;
            this.Sem1.Text = "Semester 1";
            this.Sem1.UseVisualStyleBackColor = true;
            this.Sem1.CheckedChanged += new System.EventHandler(this.Sem1_CheckedChanged);
            // 
            // MatkulPilihan
            // 
            this.MatkulPilihan.Controls.Add(this.SCM);
            this.MatkulPilihan.Controls.Add(this.PendidikanPancasila);
            this.MatkulPilihan.Controls.Add(this.Algoritma2);
            this.MatkulPilihan.Controls.Add(this.Algoritma1);
            this.MatkulPilihan.Controls.Add(this.LiterasiData);
            this.MatkulPilihan.Controls.Add(this.BasisData2);
            this.MatkulPilihan.Controls.Add(this.BasisData1);
            this.MatkulPilihan.Controls.Add(this.LiterasiTeknologi);
            this.MatkulPilihan.Controls.Add(this.Pemrograman2);
            this.MatkulPilihan.Controls.Add(this.Pemrograman1);
            this.MatkulPilihan.Controls.Add(this.AljabarLinear);
            this.MatkulPilihan.Controls.Add(this.MtkDiskrit);
            this.MatkulPilihan.Location = new System.Drawing.Point(277, 265);
            this.MatkulPilihan.Margin = new System.Windows.Forms.Padding(2);
            this.MatkulPilihan.Name = "MatkulPilihan";
            this.MatkulPilihan.Padding = new System.Windows.Forms.Padding(2);
            this.MatkulPilihan.Size = new System.Drawing.Size(489, 144);
            this.MatkulPilihan.TabIndex = 18;
            this.MatkulPilihan.TabStop = false;
            this.MatkulPilihan.Text = "Mata Kuliah Pilihan";
            // 
            // SCM
            // 
            this.SCM.AutoSize = true;
            this.SCM.Location = new System.Drawing.Point(323, 113);
            this.SCM.Margin = new System.Windows.Forms.Padding(2);
            this.SCM.Name = "SCM";
            this.SCM.Size = new System.Drawing.Size(161, 17);
            this.SCM.TabIndex = 11;
            this.SCM.Text = "Pengantar Logistik dan SCM";
            this.SCM.UseVisualStyleBackColor = true;
            // 
            // PendidikanPancasila
            // 
            this.PendidikanPancasila.AutoSize = true;
            this.PendidikanPancasila.Location = new System.Drawing.Point(323, 84);
            this.PendidikanPancasila.Margin = new System.Windows.Forms.Padding(2);
            this.PendidikanPancasila.Name = "PendidikanPancasila";
            this.PendidikanPancasila.Size = new System.Drawing.Size(128, 17);
            this.PendidikanPancasila.TabIndex = 10;
            this.PendidikanPancasila.Text = "Pendidikan Pancasila";
            this.PendidikanPancasila.UseVisualStyleBackColor = true;
            // 
            // Algoritma2
            // 
            this.Algoritma2.AutoSize = true;
            this.Algoritma2.Location = new System.Drawing.Point(323, 55);
            this.Algoritma2.Margin = new System.Windows.Forms.Padding(2);
            this.Algoritma2.Name = "Algoritma2";
            this.Algoritma2.Size = new System.Drawing.Size(165, 17);
            this.Algoritma2.TabIndex = 9;
            this.Algoritma2.Text = "Algoritma dan Struktur Data II";
            this.Algoritma2.UseVisualStyleBackColor = true;
            // 
            // Algoritma1
            // 
            this.Algoritma1.AutoSize = true;
            this.Algoritma1.Location = new System.Drawing.Point(323, 25);
            this.Algoritma1.Margin = new System.Windows.Forms.Padding(2);
            this.Algoritma1.Name = "Algoritma1";
            this.Algoritma1.Size = new System.Drawing.Size(162, 17);
            this.Algoritma1.TabIndex = 8;
            this.Algoritma1.Text = "Algoritma dan Struktur Data I";
            this.Algoritma1.UseVisualStyleBackColor = true;
            // 
            // LiterasiData
            // 
            this.LiterasiData.AutoSize = true;
            this.LiterasiData.Location = new System.Drawing.Point(188, 113);
            this.LiterasiData.Margin = new System.Windows.Forms.Padding(2);
            this.LiterasiData.Name = "LiterasiData";
            this.LiterasiData.Size = new System.Drawing.Size(85, 17);
            this.LiterasiData.TabIndex = 7;
            this.LiterasiData.Text = "Literasi Data";
            this.LiterasiData.UseVisualStyleBackColor = true;
            // 
            // BasisData2
            // 
            this.BasisData2.AutoSize = true;
            this.BasisData2.Location = new System.Drawing.Point(188, 84);
            this.BasisData2.Margin = new System.Windows.Forms.Padding(2);
            this.BasisData2.Name = "BasisData2";
            this.BasisData2.Size = new System.Drawing.Size(86, 17);
            this.BasisData2.TabIndex = 6;
            this.BasisData2.Text = "Basis Data II";
            this.BasisData2.UseVisualStyleBackColor = true;
            // 
            // BasisData1
            // 
            this.BasisData1.AutoSize = true;
            this.BasisData1.Location = new System.Drawing.Point(188, 55);
            this.BasisData1.Margin = new System.Windows.Forms.Padding(2);
            this.BasisData1.Name = "BasisData1";
            this.BasisData1.Size = new System.Drawing.Size(83, 17);
            this.BasisData1.TabIndex = 5;
            this.BasisData1.Text = "Basis Data I";
            this.BasisData1.UseVisualStyleBackColor = true;
            // 
            // LiterasiTeknologi
            // 
            this.LiterasiTeknologi.AutoSize = true;
            this.LiterasiTeknologi.Location = new System.Drawing.Point(188, 25);
            this.LiterasiTeknologi.Margin = new System.Windows.Forms.Padding(2);
            this.LiterasiTeknologi.Name = "LiterasiTeknologi";
            this.LiterasiTeknologi.Size = new System.Drawing.Size(109, 17);
            this.LiterasiTeknologi.TabIndex = 4;
            this.LiterasiTeknologi.Text = "Literasi Teknologi";
            this.LiterasiTeknologi.UseVisualStyleBackColor = true;
            // 
            // Pemrograman2
            // 
            this.Pemrograman2.AutoSize = true;
            this.Pemrograman2.Location = new System.Drawing.Point(17, 113);
            this.Pemrograman2.Margin = new System.Windows.Forms.Padding(2);
            this.Pemrograman2.Name = "Pemrograman2";
            this.Pemrograman2.Size = new System.Drawing.Size(100, 17);
            this.Pemrograman2.TabIndex = 3;
            this.Pemrograman2.Text = "Pemrograman II";
            this.Pemrograman2.UseVisualStyleBackColor = true;
            // 
            // Pemrograman1
            // 
            this.Pemrograman1.AutoSize = true;
            this.Pemrograman1.Location = new System.Drawing.Point(17, 84);
            this.Pemrograman1.Margin = new System.Windows.Forms.Padding(2);
            this.Pemrograman1.Name = "Pemrograman1";
            this.Pemrograman1.Size = new System.Drawing.Size(97, 17);
            this.Pemrograman1.TabIndex = 2;
            this.Pemrograman1.Text = "Pemrograman I";
            this.Pemrograman1.UseVisualStyleBackColor = true;
            // 
            // AljabarLinear
            // 
            this.AljabarLinear.AutoSize = true;
            this.AljabarLinear.Location = new System.Drawing.Point(17, 55);
            this.AljabarLinear.Margin = new System.Windows.Forms.Padding(2);
            this.AljabarLinear.Name = "AljabarLinear";
            this.AljabarLinear.Size = new System.Drawing.Size(90, 17);
            this.AljabarLinear.TabIndex = 1;
            this.AljabarLinear.Text = "Aljabar Linear";
            this.AljabarLinear.UseVisualStyleBackColor = true;
            // 
            // MtkDiskrit
            // 
            this.MtkDiskrit.AutoSize = true;
            this.MtkDiskrit.Location = new System.Drawing.Point(17, 25);
            this.MtkDiskrit.Margin = new System.Windows.Forms.Padding(2);
            this.MtkDiskrit.Name = "MtkDiskrit";
            this.MtkDiskrit.Size = new System.Drawing.Size(113, 17);
            this.MtkDiskrit.TabIndex = 0;
            this.MtkDiskrit.Text = "Matematika Diskrit";
            this.MtkDiskrit.UseVisualStyleBackColor = true;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(291, 427);
            this.BtnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(73, 27);
            this.BtnSimpan.TabIndex = 19;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnBatal
            // 
            this.BtnBatal.Location = new System.Drawing.Point(457, 427);
            this.BtnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Size = new System.Drawing.Size(73, 27);
            this.BtnBatal.TabIndex = 20;
            this.BtnBatal.Text = "Batal";
            this.BtnBatal.UseVisualStyleBackColor = true;
            this.BtnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 456);
            this.Controls.Add(this.BtnBatal);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.MatkulPilihan);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.PilihMatkul);
            this.Controls.Add(this.ProgramStudi);
            this.Controls.Add(this.Perempuan);
            this.Controls.Add(this.LakiLaki);
            this.Controls.Add(this.Kelas);
            this.Controls.Add(this.TahunAkademik);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.Npm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.Semester.ResumeLayout(false);
            this.Semester.PerformLayout();
            this.MatkulPilihan.ResumeLayout(false);
            this.MatkulPilihan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Npm;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.TextBox TahunAkademik;
        private System.Windows.Forms.TextBox Kelas;
        private System.Windows.Forms.RadioButton LakiLaki;
        private System.Windows.Forms.RadioButton Perempuan;
        private System.Windows.Forms.ComboBox ProgramStudi;
        private System.Windows.Forms.Button PilihMatkul;
        private System.Windows.Forms.GroupBox Semester;
        private System.Windows.Forms.RadioButton Sem3;
        private System.Windows.Forms.RadioButton Sem2;
        private System.Windows.Forms.RadioButton Sem1;
        private System.Windows.Forms.GroupBox MatkulPilihan;
        private System.Windows.Forms.CheckBox SCM;
        private System.Windows.Forms.CheckBox PendidikanPancasila;
        private System.Windows.Forms.CheckBox Algoritma2;
        private System.Windows.Forms.CheckBox Algoritma1;
        private System.Windows.Forms.CheckBox LiterasiData;
        private System.Windows.Forms.CheckBox BasisData2;
        private System.Windows.Forms.CheckBox BasisData1;
        private System.Windows.Forms.CheckBox LiterasiTeknologi;
        private System.Windows.Forms.CheckBox Pemrograman2;
        private System.Windows.Forms.CheckBox Pemrograman1;
        private System.Windows.Forms.CheckBox AljabarLinear;
        private System.Windows.Forms.CheckBox MtkDiskrit;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnBatal;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epWarning;
    }
}