namespace PBOBarberMate.View.FormKelolaKaryawan
{
    partial class FiturTambahKaryawan
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnSelesaiFiturPresensiKaryawan = new Button();
            btnBatalFiturPresensiKaryawan = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 133);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 13;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 96);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 12;
            label2.Text = "EMAIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 59);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 11;
            label1.Text = "NAMA AKUN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 23);
            textBox3.TabIndex = 19;
            // 
            // btnSelesaiFiturPresensiKaryawan
            // 
            btnSelesaiFiturPresensiKaryawan.Location = new Point(670, 403);
            btnSelesaiFiturPresensiKaryawan.Name = "btnSelesaiFiturPresensiKaryawan";
            btnSelesaiFiturPresensiKaryawan.Size = new Size(75, 23);
            btnSelesaiFiturPresensiKaryawan.TabIndex = 21;
            btnSelesaiFiturPresensiKaryawan.Text = "SELESAI";
            btnSelesaiFiturPresensiKaryawan.UseVisualStyleBackColor = true;
            btnSelesaiFiturPresensiKaryawan.Click += btnSelesaiFiturPresensiKaryawan_Click;
            // 
            // btnBatalFiturPresensiKaryawan
            // 
            btnBatalFiturPresensiKaryawan.Location = new Point(589, 403);
            btnBatalFiturPresensiKaryawan.Name = "btnBatalFiturPresensiKaryawan";
            btnBatalFiturPresensiKaryawan.Size = new Size(75, 23);
            btnBatalFiturPresensiKaryawan.TabIndex = 20;
            btnBatalFiturPresensiKaryawan.Text = "BATAL";
            btnBatalFiturPresensiKaryawan.UseVisualStyleBackColor = true;
            btnBatalFiturPresensiKaryawan.Click += btnBatalFiturPresensiKaryawan_Click;
            // 
            // FiturTambahKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelesaiFiturPresensiKaryawan);
            Controls.Add(btnBatalFiturPresensiKaryawan);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FiturTambahKaryawan";
            Text = "FiturTambahKaryawan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnSelesaiFiturPresensiKaryawan;
        private Button btnBatalFiturPresensiKaryawan;
    }
}