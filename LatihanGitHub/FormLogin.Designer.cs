namespace LatihanGitHub
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtid = new TextBox();
            label3 = new Label();
            txtnis = new TextBox();
            btnSimpan = new Button();
            btnHapus = new Button();
            label4 = new Label();
            label5 = new Label();
            txtnama = new TextBox();
            txtpas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 33);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 122);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // txtid
            // 
            txtid.Location = new Point(273, 114);
            txtid.Name = "txtid";
            txtid.Size = new Size(188, 23);
            txtid.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 174);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "NIS";
            // 
            // txtnis
            // 
            txtnis.Location = new Point(273, 166);
            txtnis.Name = "txtnis";
            txtnis.Size = new Size(188, 23);
            txtnis.TabIndex = 4;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(401, 384);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(107, 37);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(195, 385);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(104, 36);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 236);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Nama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 294);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // txtnama
            // 
            txtnama.Location = new Point(273, 228);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(188, 23);
            txtnama.TabIndex = 9;
            // 
            // txtpas
            // 
            txtpas.Location = new Point(273, 286);
            txtpas.Name = "txtpas";
            txtpas.Size = new Size(188, 23);
            txtpas.TabIndex = 10;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 575);
            Controls.Add(txtpas);
            Controls.Add(txtnama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnHapus);
            Controls.Add(btnSimpan);
            Controls.Add(txtnis);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Form Login";
            Load += this.FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtid;
        private Label label3;
        private TextBox txtnis;
        private Button btnSimpan;
        private Button btnHapus;
        private Label label4;
        private Label label5;
        private TextBox txtnama;
        private TextBox txtpas;
    }
}
