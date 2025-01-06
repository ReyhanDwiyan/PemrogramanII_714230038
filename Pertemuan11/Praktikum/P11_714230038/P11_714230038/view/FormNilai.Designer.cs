namespace P11_714230038.view
{
    partial class FormNilai
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.checkBoxMatkul = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textBoxCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxKategori = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxNpm = new System.Windows.Forms.ComboBox();
            this.textBoxNilai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(23, 140);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(383, 31);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(23, 68);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(383, 27);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatkul
            // 
            this.checkBoxMatkul.FormattingEnabled = true;
            this.checkBoxMatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I "});
            this.checkBoxMatkul.Location = new System.Drawing.Point(108, 43);
            this.checkBoxMatkul.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMatkul.Name = "checkBoxMatkul";
            this.checkBoxMatkul.Size = new System.Drawing.Size(357, 30);
            this.checkBoxMatkul.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(787, 359);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(413, 183);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(23, 102);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(383, 31);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(23, 30);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(383, 31);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // textBoxCariData
            // 
            this.textBoxCariData.Location = new System.Drawing.Point(112, 30);
            this.textBoxCariData.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCariData.Name = "textBoxCariData";
            this.textBoxCariData.Size = new System.Drawing.Size(292, 26);
            this.textBoxCariData.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // checkBoxKategori
            // 
            this.checkBoxKategori.FormattingEnabled = true;
            this.checkBoxKategori.Items.AddRange(new object[] {
            "ATS",
            "AAS"});
            this.checkBoxKategori.Location = new System.Drawing.Point(108, 96);
            this.checkBoxKategori.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxKategori.Name = "checkBoxKategori";
            this.checkBoxKategori.Size = new System.Drawing.Size(357, 30);
            this.checkBoxKategori.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCariData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(787, 280);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(413, 71);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Form Pencarian";
            // 
            // checkBoxNpm
            // 
            this.checkBoxNpm.FormattingEnabled = true;
            this.checkBoxNpm.Location = new System.Drawing.Point(108, 145);
            this.checkBoxNpm.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNpm.Name = "checkBoxNpm";
            this.checkBoxNpm.Size = new System.Drawing.Size(357, 30);
            this.checkBoxNpm.TabIndex = 13;
            // 
            // textBoxNilai
            // 
            this.textBoxNilai.Location = new System.Drawing.Point(108, 197);
            this.textBoxNilai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNilai.Name = "textBoxNilai";
            this.textBoxNilai.Size = new System.Drawing.Size(357, 26);
            this.textBoxNilai.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkul";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNama);
            this.groupBox2.Controls.Add(this.checkBoxNpm);
            this.groupBox2.Controls.Add(this.checkBoxKategori);
            this.groupBox2.Controls.Add(this.textBoxNilai);
            this.groupBox2.Controls.Add(this.checkBoxMatkul);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 280);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(764, 261);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Nilai";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(475, 145);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.ReadOnly = true;
            this.textBoxNama.Size = new System.Drawing.Size(280, 26);
            this.textBoxNama.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataNilai);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1185, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data Nilai";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(8, 27);
            this.DataNilai.Margin = new System.Windows.Forms.Padding(4);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.RowHeadersWidth = 62;
            this.DataNilai.Size = new System.Drawing.Size(1169, 225);
            this.DataNilai.TabIndex = 0;
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox checkBoxMatkul;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBoxCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox checkBoxKategori;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox checkBoxNpm;
        private System.Windows.Forms.TextBox textBoxNilai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataNilai;
    }
}