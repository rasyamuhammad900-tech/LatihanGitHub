namespace LatihanGitHub
{
    partial class FormSiswa
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
            lblid = new Label();
            lblnama = new Label();
            lblkelas = new Label();
            lblalamat = new Label();
            lbljk = new Label();
            cblaki = new CheckBox();
            cbperempuan = new CheckBox();
            txtnama = new TextBox();
            txtkelas = new TextBox();
            txtalamat = new TextBox();
            btnsimpan = new Button();
            btnhapus = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(14, 10);
            lblid.Name = "lblid";
            lblid.Size = new Size(30, 25);
            lblid.TabIndex = 0;
            lblid.Text = "ID";
            // 
            // lblnama
            // 
            lblnama.AutoSize = true;
            lblnama.Location = new Point(14, 47);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(59, 25);
            lblnama.TabIndex = 1;
            lblnama.Text = "Nama";
            lblnama.Click += label1_Click;
            // 
            // lblkelas
            // 
            lblkelas.AutoSize = true;
            lblkelas.Location = new Point(14, 88);
            lblkelas.Name = "lblkelas";
            lblkelas.Size = new Size(52, 25);
            lblkelas.TabIndex = 2;
            lblkelas.Text = "Kelas";
            // 
            // lblalamat
            // 
            lblalamat.AutoSize = true;
            lblalamat.Location = new Point(14, 130);
            lblalamat.Name = "lblalamat";
            lblalamat.Size = new Size(68, 25);
            lblalamat.TabIndex = 3;
            lblalamat.Text = "Alamat";
            // 
            // lbljk
            // 
            lbljk.AutoSize = true;
            lbljk.Location = new Point(14, 180);
            lbljk.Name = "lbljk";
            lbljk.Size = new Size(116, 25);
            lbljk.TabIndex = 4;
            lbljk.Text = "Jenis Kelamin";
            // 
            // cblaki
            // 
            cblaki.AutoSize = true;
            cblaki.Location = new Point(136, 179);
            cblaki.Name = "cblaki";
            cblaki.Size = new Size(101, 29);
            cblaki.TabIndex = 5;
            cblaki.Text = "Laki-laki";
            cblaki.UseVisualStyleBackColor = true;
            cblaki.CheckedChanged += cblaki_CheckedChanged;
            // 
            // cbperempuan
            // 
            cbperempuan.AutoSize = true;
            cbperempuan.Location = new Point(136, 214);
            cbperempuan.Name = "cbperempuan";
            cbperempuan.Size = new Size(127, 29);
            cbperempuan.TabIndex = 6;
            cbperempuan.Text = "Perempuan";
            cbperempuan.UseVisualStyleBackColor = true;
            // 
            // txtnama
            // 
            txtnama.Location = new Point(97, 44);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(150, 31);
            txtnama.TabIndex = 7;
            // 
            // txtkelas
            // 
            txtkelas.Location = new Point(97, 85);
            txtkelas.Name = "txtkelas";
            txtkelas.Size = new Size(150, 31);
            txtkelas.TabIndex = 8;
            // 
            // txtalamat
            // 
            txtalamat.Location = new Point(97, 130);
            txtalamat.Name = "txtalamat";
            txtalamat.Size = new Size(150, 31);
            txtalamat.TabIndex = 9;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(11, 248);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(112, 34);
            btnsimpan.TabIndex = 10;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            btnhapus.Location = new Point(164, 249);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(112, 34);
            btnhapus.TabIndex = 11;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(14, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(821, 383);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "NAMA";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "KELAS";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "ALAMAT";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "JENIS KELAMIN";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 782);
            Controls.Add(dataGridView1);
            Controls.Add(btnhapus);
            Controls.Add(btnsimpan);
            Controls.Add(txtalamat);
            Controls.Add(txtkelas);
            Controls.Add(txtnama);
            Controls.Add(cbperempuan);
            Controls.Add(cblaki);
            Controls.Add(lbljk);
            Controls.Add(lblalamat);
            Controls.Add(lblkelas);
            Controls.Add(lblnama);
            Controls.Add(lblid);
            Name = "FormSiswa";
            Text = "FormSiswa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private Label lblnama;
        private Label lblkelas;
        private Label lblalamat;
        private Label lbljk;
        private CheckBox cblaki;
        private CheckBox cbperempuan;
        private TextBox txtnama;
        private TextBox txtkelas;
        private TextBox txtalamat;
        private Button btnsimpan;
        private Button btnhapus;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}