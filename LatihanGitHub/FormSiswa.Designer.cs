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
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(10, 6);
            lblid.Margin = new Padding(2, 0, 2, 0);
            lblid.Name = "lblid";
            lblid.Size = new Size(18, 15);
            lblid.TabIndex = 0;
            lblid.Text = "ID";
            // 
            // lblnama
            // 
            lblnama.AutoSize = true;
            lblnama.Location = new Point(10, 28);
            lblnama.Margin = new Padding(2, 0, 2, 0);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(39, 15);
            lblnama.TabIndex = 1;
            lblnama.Text = "Nama";
            lblnama.Click += label1_Click;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 332);
            Controls.Add(lblnama);
            Controls.Add(lblid);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormSiswa";
            Text = "FormSiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private Label lblnama;
    }
}