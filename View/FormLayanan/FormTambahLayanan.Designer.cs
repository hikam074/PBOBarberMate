namespace PBOBarberMate.View
{
    partial class FormTambahLayanan
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
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblHarga = new Label();
            lblNamaLayanan = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 0;
            label1.Text = "TAMBAHKAN LAYANAN";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(619, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(700, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(497, 23);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(497, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(99, 139);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(39, 15);
            lblHarga.TabIndex = 13;
            lblHarga.Text = "Harga";
            // 
            // lblNamaLayanan
            // 
            lblNamaLayanan.AutoSize = true;
            lblNamaLayanan.Location = new Point(99, 85);
            lblNamaLayanan.Name = "lblNamaLayanan";
            lblNamaLayanan.Size = new Size(83, 15);
            lblNamaLayanan.TabIndex = 12;
            lblNamaLayanan.Text = "Nama layanan";
            // 
            // FormTambahLayanan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 267);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaLayanan);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormTambahLayanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTambahLayanan";
            Load += FormTambahLayanan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblHarga;
        private Label lblNamaLayanan;
    }
}