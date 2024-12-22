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
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnCancel.ForeColor = Color.FromArgb(44, 62, 80);
            btnCancel.Location = new Point(12, 450);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 39);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnAdd.ForeColor = Color.FromArgb(44, 62, 80);
            btnAdd.Location = new Point(857, 450);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 39);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(267, 297);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(497, 23);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(497, 23);
            textBox1.TabIndex = 27;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblHarga.Location = new Point(165, 300);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(81, 18);
            lblHarga.TabIndex = 26;
            lblHarga.Text = "Jumlah Barang";
            // 
            // lblNamaLayanan
            // 
            lblNamaLayanan.AutoSize = true;
            lblNamaLayanan.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblNamaLayanan.Location = new Point(165, 206);
            lblNamaLayanan.Name = "lblNamaLayanan";
            lblNamaLayanan.Size = new Size(74, 18);
            lblNamaLayanan.TabIndex = 25;
            lblNamaLayanan.Text = "Nama Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold);
            label1.Location = new Point(311, 63);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 58);
            label1.TabIndex = 24;
            label1.Text = "TAMBAHKAN BARANG";
            // 
            // FormTambahInventaris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaLayanan);
            Controls.Add(label1);
            Margin = new Padding(2);
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