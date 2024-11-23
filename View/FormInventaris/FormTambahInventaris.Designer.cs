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
            btnCancel.Location = new Point(869, 380);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(985, 380);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 254);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(708, 31);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 164);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(708, 31);
            textBox1.TabIndex = 27;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(126, 259);
            lblHarga.Margin = new Padding(4, 0, 4, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(127, 25);
            lblHarga.TabIndex = 26;
            lblHarga.Text = "Jumlah Branag";
            // 
            // lblNamaLayanan
            // 
            lblNamaLayanan.AutoSize = true;
            lblNamaLayanan.Location = new Point(126, 169);
            lblNamaLayanan.Margin = new Padding(4, 0, 4, 0);
            lblNamaLayanan.Name = "lblNamaLayanan";
            lblNamaLayanan.Size = new Size(119, 25);
            lblNamaLayanan.TabIndex = 25;
            lblNamaLayanan.Text = "Nama Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 59);
            label1.Name = "label1";
            label1.Size = new Size(385, 48);
            label1.TabIndex = 24;
            label1.Text = "TAMBAHKAN BARANG";
            // 
            // FormTambahInventaris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 476);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaLayanan);
            Controls.Add(label1);
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