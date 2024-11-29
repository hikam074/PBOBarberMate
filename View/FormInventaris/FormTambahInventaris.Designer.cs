namespace PBOBarberMate.View.FormInventaris
{
    partial class FormTambahInventaris
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
            btnCancel = new Button();
            btnAdd = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblHarga = new Label();
            lblNamaLayanan = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(608, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(690, 228);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(497, 23);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(497, 23);
            textBox1.TabIndex = 27;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(88, 155);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(85, 15);
            lblHarga.TabIndex = 26;
            lblHarga.Text = "Jumlah Barang";
            // 
            // lblNamaLayanan
            // 
            lblNamaLayanan.AutoSize = true;
            lblNamaLayanan.Location = new Point(88, 101);
            lblNamaLayanan.Name = "lblNamaLayanan";
            lblNamaLayanan.Size = new Size(79, 15);
            lblNamaLayanan.TabIndex = 25;
            lblNamaLayanan.Text = "Nama Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 24;
            label1.Text = "TAMBAHKAN BARANG";
            // 
            // FormTambahInventaris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 286);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaLayanan);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormTambahInventaris";
            Text = "FormTambahInventaris";
            Load += FormTambahInventaris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblHarga;
        private Label lblNamaLayanan;
        private Label label1;
    }
}