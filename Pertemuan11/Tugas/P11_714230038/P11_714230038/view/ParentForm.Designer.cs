﻿namespace P11_714230038.view
{
    partial class ParentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tugasPratikum11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.dataMahasiswaToolStripMenuItem,
            this.tugasPratikum11ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.dataToolStripMenuItem.Text = "Data Nilai";
            // 
            // dataMahasiswaToolStripMenuItem
            // 
            this.dataMahasiswaToolStripMenuItem.Name = "dataMahasiswaToolStripMenuItem";
            this.dataMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.dataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa";
            // 
            // tugasPratikum11ToolStripMenuItem
            // 
            this.tugasPratikum11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterBarangToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem});
            this.tugasPratikum11ToolStripMenuItem.Name = "tugasPratikum11ToolStripMenuItem";
            this.tugasPratikum11ToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.tugasPratikum11ToolStripMenuItem.Text = "Tugas Pratikum 11";
            this.tugasPratikum11ToolStripMenuItem.Click += new System.EventHandler(this.tugasPratikum11ToolStripMenuItem_Click);
            // 
            // dataMasterBarangToolStripMenuItem
            // 
            this.dataMasterBarangToolStripMenuItem.Name = "dataMasterBarangToolStripMenuItem";
            this.dataMasterBarangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataMasterBarangToolStripMenuItem.Text = "Data Master Barang";
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tugasPratikum11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMasterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
    }
}