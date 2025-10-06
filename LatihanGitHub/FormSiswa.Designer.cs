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
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 360);
            Controls.Add(lblnama);
            Controls.Add(lblid);
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