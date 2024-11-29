namespace PBOBarberMate.View.FormShift
{
    partial class FormTambahJadwal
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
            lblAddJadwal = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnKembali = new Button();
            btnTambahkan = new Button();
            SuspendLayout();
            // 
            // lblAddJadwal
            // 
            lblAddJadwal.AutoSize = true;
            lblAddJadwal.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddJadwal.Location = new Point(286, 25);
            lblAddJadwal.Name = "lblAddJadwal";
            lblAddJadwal.Size = new Size(236, 29);
            lblAddJadwal.TabIndex = 0;
            lblAddJadwal.Text = "Tambah Jadwal Shift";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 116);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 208);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 111);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(334, 203);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 4;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(555, 304);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(82, 22);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnTambahkan
            // 
            btnTambahkan.Location = new Point(662, 304);
            btnTambahkan.Margin = new Padding(3, 2, 3, 2);
            btnTambahkan.Name = "btnTambahkan";
            btnTambahkan.Size = new Size(82, 22);
            btnTambahkan.TabIndex = 6;
            btnTambahkan.Text = "Tambahkan";
            btnTambahkan.UseVisualStyleBackColor = true;
            btnTambahkan.Click += btnTambahkan_Click;
            // 
            // FormTambahJadwal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 388);
            Controls.Add(btnTambahkan);
            Controls.Add(btnKembali);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAddJadwal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTambahJadwal";
            Text = "FormTambahJadwal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddJadwal;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button btnKembali;
        private Button btnTambahkan;
    }
}